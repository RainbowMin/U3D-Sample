using UnityEngine;
using System.Collections;

public class Script_03_19 : MonoBehaviour 
{
	Object[] animList;
	int CurFrame;
	int TotalFrameCount;
	float FPS = 15;
	float time = 0;

	//支持中文
	// Use this for initialization
	void Start () 
	{
		animList = Resources.LoadAll("animation");
		TotalFrameCount = animList.Length;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		DrawAnimation(animList,new Rect(100,100,32,48));
	}
	
	void DrawAnimation(Object[] tex, Rect rect)
	{
		GUILayout.Label("当前动画播放：第"+CurFrame+"帧");
		GUI.DrawTexture(rect, (Texture2D)tex[CurFrame], ScaleMode.StretchToFill, true, 0);
		time += Time.deltaTime;
		if(time > 1.0 / FPS)
		{
			CurFrame++;
			time = 0;
			if(CurFrame >= TotalFrameCount)
			{
				CurFrame = 0;
			}
		}
	}
}
