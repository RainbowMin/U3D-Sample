using UnityEngine;
using System.Collections;

public class Script_03_01 : MonoBehaviour 
{
	 public string str;
     public Texture ImageTexture;
     private int ImageWidth;
     private int ImageHeight;
     private int ScreenWidth;
     private int ScreenHeight;
	
	//支持中文
	// Use this for initialization
	void Start () 
	{
		Debug.Log("支持中文");
		ScreenWidth = Screen.width;
        ScreenHeight = Screen.height;
        ImageWidth = ImageTexture.width;
        ImageHeight = ImageTexture.height;
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	
	void OnGUI()
	{
		  GUI.Label(new Rect(100,10,100,30),str);
          GUI.Label(new Rect(100,40,100,30), "当前屏幕宽:"+ScreenWidth);
          GUI.Label(new Rect(100,80,100,30), "当前屏幕高:"+ScreenHeight);
          GUI.Label(new Rect(100,120,ImageWidth, ImageHeight), ImageTexture);
	}
}
