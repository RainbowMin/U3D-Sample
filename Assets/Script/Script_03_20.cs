using UnityEngine;
using System.Collections;

public class Script_03_20 : MonoBehaviour 
{
	Object[] animUp, animDown, animLeft, animRight;
	Texture2D Map;
	Object[] CurAnim;
	int PosX, PosY;
	int CurFrame;
	int TotalFrameCount;
	float fps = 10;
	float time = 0;
	
	// Use this for initialization
	void Start () 
	{
		animUp = Resources.LoadAll ("ch3_20/up");
		animDown = Resources.LoadAll ("ch3_20/down");
		animLeft = Resources.LoadAll("ch3_20/left");
		animRight = Resources.LoadAll("ch3_20/right");
		Map = (Texture2D)Resources.Load ("ch3_20/map/map");
		CurAnim = animUp;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height), Map, ScaleMode.StretchToFill, true, 0);
		DrawAnimation(CurAnim, new Rect(PosX, PosY, 32,48));
		
		if(GUILayout.RepeatButton("向上"))
		{
			PosY-=2;
			CurAnim = animUp;
		}
		if(GUILayout.RepeatButton("向下"))
		{
			PosY+=2;
			CurAnim = animDown;
		}
		if(GUILayout.RepeatButton("向左"))
		{
			PosX-=2;
			CurAnim = animLeft;
		}
		if(GUILayout.RepeatButton("向右"))
		{
			PosX+=2;
			CurAnim = animRight;
		}
	}
	
	void DrawAnimation(Object[] tex, Rect rect)
	{
		GUILayout.Label("当前动画播放：第"+CurFrame+"帧");
		GUI.DrawTexture(rect, (Texture2D)tex[CurFrame], ScaleMode.StretchToFill, true, 0);
		time += Time.deltaTime;
		if(time > 1.0 / fps)
		{
			CurFrame++;
			time = 0;
			if(CurFrame >= CurAnim.Length)
			{
				CurFrame = 0;
			}
		}
	}
}
