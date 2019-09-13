using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Counter : MonoBehaviour {

	public Text coin_text;
	public int coin_count;
	// Use this for initialization
	void Start () {
		coin_count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Coin_Counting(int c_value)
	{
		coin_count += c_value;
		coin_text.text = "Coin: " + coin_count.ToString();
		
		
	}
}
