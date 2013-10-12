using UnityEngine;
using System.Collections;

public class Script_02_01 : MonoBehaviour {
	
	public int TranslateSpeed = 20;
	public int RotateSpeed = 1000;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		GUI.backgroundColor = Color.red;
		if(GUI.Button(new Rect(10,10,70,45), "Turn Left"))
		{
			transform.Rotate(Vector3.up * Time.deltaTime * -RotateSpeed);
		}
		
	    if(GUI.Button(new Rect(90,10,70,45), "Move Forward"))
		{
			transform.Translate(Vector3.forward * Time.deltaTime * -TranslateSpeed);
		}	
		
		if(GUI.Button(new Rect(170,10,70,45), "Turn Right"))
		{
			transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed);
		}
		
		if(GUI.Button(new Rect(90,50,70,45), "Move Behind"))
		{
			transform.Translate(Vector3.forward * Time.deltaTime * TranslateSpeed);
		}	
		
		if(GUI.Button(new Rect(10,50,70,45), "Move Left"))
		{
			transform.Translate(Vector3.left * Time.deltaTime * TranslateSpeed);
		}	
		
		if(GUI.Button(new Rect(170,50,70,45), "Move Right"))
		{
			transform.Translate(Vector3.right * Time.deltaTime * TranslateSpeed);
		}	
	}
}
