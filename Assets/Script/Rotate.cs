using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public int RotateSpeed = 20;
	private int RotateSpeed_Private = 20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(Vector3.up, Time.deltaTime*20);	
	}
}
