using UnityEngine;
using System.Collections;

public class Script_03_21 : MonoBehaviour 
{
	GameObject hero;
	bool KeyUp, KeyDown, KeyLeft, KeyRight;
	float time;
	float fps = 10;
	int CurFrame;
	Object[] animUp, animDown, animLeft, animRight, CurAnim, PreviousAnim;
	
	void Start () 
	{
		hero = GameObject.Find("hero");
		animUp = Resources.LoadAll ("ch3_20/up");
		animDown = Resources.LoadAll ("ch3_20/down");
		animLeft = Resources.LoadAll("ch3_20/left");
		animRight = Resources.LoadAll("ch3_20/right");
		CurAnim = animDown;
		PreviousAnim = animDown;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		KeyUp = GUILayout.RepeatButton("向上");
		KeyDown = GUILayout.RepeatButton("向下");
		KeyLeft = GUILayout.RepeatButton("向左");
		KeyRight = GUILayout.RepeatButton("向右");
	}
	
	void FixedUpdate()
	{
		if(KeyUp)
		{
			SetAnimation(animUp);
			hero.transform.Translate(-Vector3.up*0.1f);
		}
		if(KeyDown)
		{
			SetAnimation(animDown);
			hero.transform.Translate(Vector3.up*0.1f);
		}
		if(KeyLeft)
		{
			SetAnimation(animLeft);
			hero.transform.Translate(Vector3.right*0.1f);
		}
		if(KeyRight)
		{
			SetAnimation(animRight);
			hero.transform.Translate(-Vector3.right*0.1f);
		}
		DrawAnimation(CurAnim);
	}
	
	void SetAnimation(Object[] tex)
	{
		CurAnim = tex;
		if(!PreviousAnim.Equals(CurAnim))
		{
			CurFrame = 0;
			PreviousAnim = CurAnim;
		}
	}
	void DrawAnimation(Object[] tex)
	{
		time += Time.deltaTime;
		if(time >= 1.0 / fps)
		{
			CurFrame++;
			time = 0;
			if(CurFrame >= tex.Length)
			{
				CurFrame = 0;
			}
		}
		hero.renderer.material.mainTexture = (Texture2D)tex[CurFrame];
	}
}
