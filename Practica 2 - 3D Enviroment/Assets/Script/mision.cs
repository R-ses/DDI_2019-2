using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mision : MonoBehaviour {


	public Text texto; 
	public Text Capsule_text;
	public Coin_Counter c_counter;
	private bool flag;
	public AudioSource victory_music;
	public GameObject Capsule;
	private bool cap_flag;

	// Use this for initialization
	void Start () {
		flag = false;
		cap_flag = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.E))
		{
			
			Capsule.GetComponent<Renderer>().material.color = Color.green;
			cap_flag = true;
			Capsule_text.text = "Muy bien, ahora intenta interactuar con otros objetos en el mapa";
		}
	}
	
	void OnTriggerEnter()
	{
		
		if(c_counter.coin_count == 70)
		{
			
			texto.text = "Bien Hecho";
			victory_music.Play(0);
			
		}
		else
		{
			if(flag == false)
			{
				texto.text = "Debes recolectar todas las monedas";
			}
			else
			{
				texto.text = "Te faltan " + (7-(c_counter.coin_count/10)).ToString(); 
			}
			
		}
		
		if(cap_flag == false){
		Capsule_text.text = "Esto es un objeto, puedes interactuar con el acercandote y precionando la tecla 'E' ";
		}
		else
		{
			
		Capsule_text.text = "Muy bien, ahora intenta interactuar con otros objetos en el mapa";
		
		}
		
	}
	
	void OnTriggerExit()
	{
		
		texto.text = "";
		Capsule_text.text = "";
		flag = true;
	
			
	}
}
