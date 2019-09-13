using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collector : MonoBehaviour {

	public GameObject self;
	private int coin_value = 10;
	public Coin_Counter c_counter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		
		Debug.Log("Moneda Collided");
		if(other.tag == "Player")
		{
		
		Debug.Log("Coin Collected");
		c_counter.Coin_Counting(coin_value);
		Destroy(self);
		}
			
	}
	
}
