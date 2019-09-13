using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mision : MonoBehaviour {


	public Text texto; 
	public Coin_Counter c_counter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter()
	{
		
		if(c_counter.coin_count == 70)
		{
			
			texto.text = "Bien Hecho";
			
		}
		else
		{
		
			texto.text = "Debes recolectar todas las monedas";
		
		}
		
		
	}
	
	void OnTriggerExit()
	{
		
		texto.text = "";
		
	}
}
