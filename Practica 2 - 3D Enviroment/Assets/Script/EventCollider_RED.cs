using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventCollider_RED : MonoBehaviour {

	public Text texto;
	public AudioSource audio;
	public GameObject self;
	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		
		
	}
	
	
	void OnTriggerEnter(Collider other)
	{
		
            Debug.Log("entered");
			texto.text = "Te estas alejando de tu objetivo" ;
			audio.Play(0);

		
	}
	
	void OnTriggerExit(Collider other)
	{
		
		Debug.Log("exit");
		texto.text = "";
		Destroy(self);

	}
}
