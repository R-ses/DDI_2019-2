using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Management : MonoBehaviour {
	public GameObject pause;
	public GameObject inventory;
	public GameObject UI_panel;
	private bool Paused;
	private bool Inv_flag;
	private bool UI_flag;
	
	// Use this for initialization
	void Start () {
		Paused = false;
		Inv_flag = false;
		UI_flag = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.P))
		{
			if(!Inv_flag){
			pause.SetActive(!Paused);	
			Paused = !Paused;
			if(Paused)
			{
				UI_panel.SetActive(false);
			}
			else
			{
				UI_panel.SetActive(true);
			}
			}
		}
		
		
		if(Input.GetKeyDown(KeyCode.I))
		{
			if(!Paused)
			{
				inventory.SetActive(!Inv_flag);
				Inv_flag = !Inv_flag;
				if(Inv_flag)
				{
					UI_panel.SetActive(false);
				}
				else
				{
					UI_panel.SetActive(true);
				}
			}
		}
	}
}
