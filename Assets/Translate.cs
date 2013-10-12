using UnityEngine;
using System.Collections;

public class Translate : MonoBehaviour {
	
	public int TranslateSpeed = 20;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.forward*20*Time.deltaTime);
	}
}
