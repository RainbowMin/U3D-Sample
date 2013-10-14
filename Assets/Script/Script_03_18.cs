using UnityEngine;
using System.Collections;

public class Script_03_18 : MonoBehaviour 
{
	Texture2D texSingle;
	Object[] texAll;

	//支持中文
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(0,10,100,50),"加载一张贴图"))
		{
			if(texSingle == null)
			{
				texSingle = (Texture2D)Resources.Load ("single/0");
			}
		}
		
		if(texSingle != null)
		{
			GUI.DrawTexture(new Rect(110,10,120,120),texSingle, ScaleMode.StretchToFill,true,0);
		}
		
		if(GUI.Button (new Rect(0,130,100,50),"加载一组贴图"))
		{
			if(texAll == null)
			{
				texAll = Resources.LoadAll("Textures");
			}
		}
		
		if(texAll != null)
		{
			for(int i=0; i < texAll.Length; i++)
			{
				GUI.DrawTexture(new Rect(110+i*120,130,120,120),(Texture2D)texAll[i],ScaleMode.StretchToFill,true,0);
			}
		}
	}
}
