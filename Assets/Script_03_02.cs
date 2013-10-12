using UnityEngine;
using System.Collections;

public class Script_03_02 : MonoBehaviour 
{
	public Texture2D ButtonTexture;
	string strPrompt;
	int FrameTime;

	//支持中文
	// Use this for initialization
	void Start () 
	{
		//初始化赋值
		strPrompt = "请您点击按钮";
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(10,10,Screen.width, 30), strPrompt);
		
		if(GUI.Button(new Rect(10,50,ButtonTexture.width, ButtonTexture.height), ButtonTexture))
		{
			strPrompt = "点击了图片按钮";

		}
					GUI.color = Color.green;
			GUI.backgroundColor = Color.red;
		
		if(GUI.Button(new Rect(10,200,70,30), "文字按钮"))
		{
			strPrompt = "点击了文字按钮";

		}
					GUI.color = Color.yellow;
			GUI.backgroundColor = Color.black;
		
		if(GUI.RepeatButton(new Rect(10,250,100,30), "按钮按下中"))
		{
			strPrompt = "按钮按下的时间"+FrameTime;
			FrameTime++;
		}

	}
}
