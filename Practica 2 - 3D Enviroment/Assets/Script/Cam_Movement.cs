using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cam_Movement : MonoBehaviour {

	public GameObject character;
	float DeltaX;
	float DeltaZ;
	float Omega;
	float tetha;
	int movement = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	

			if(Input.GetKeyDown(KeyCode.W))
			{
				Debug.Log("Avanza");
				 
				Vector3 Vec = character.transform.rotation.eulerAngles;
				tetha = Vec.y;
				
				if(tetha<0)
				{
					tetha = 360-tetha;
				}
				Debug.Log(tetha);
				if(tetha>=0 && tetha < 90){
				DeltaX = (movement*Mathf.Sin(tetha))/(Mathf.Sin(90));
				DeltaZ = (movement*Mathf.Sin(90-tetha))/(Mathf.Sin(90));
				character.transform.position = new Vector3(character.transform.position.x+DeltaX,character.transform.position.y,character.transform.position.z+DeltaZ);
				}
				else if(tetha>=90 && tetha < 180) 
				{
				DeltaX = (movement*Mathf.Sin(tetha))/(Mathf.Sin(90));
				DeltaZ = (movement*Mathf.Sin(90-tetha))/(Mathf.Sin(90));
				character.transform.position = new Vector3(character.transform.position.x-DeltaX,character.transform.position.y,character.transform.position.z+DeltaZ);
				}
				else if(tetha>=180 && tetha < 270){
				DeltaX = (movement*Mathf.Sin(tetha))/(Mathf.Sin(90));
				DeltaZ = (movement*Mathf.Sin(90-tetha))/(Mathf.Sin(90));
				character.transform.position = new Vector3(character.transform.position.x-DeltaX,character.transform.position.y,character.transform.position.z-DeltaZ);
				}
				else if(tetha>=270 && tetha < 360) 
				{
				DeltaX = (movement*Mathf.Sin(tetha))/(Mathf.Sin(90));
				DeltaZ = (movement*Mathf.Sin(90-tetha))/(Mathf.Sin(90));
				character.transform.position = new Vector3(character.transform.position.x+DeltaX,character.transform.position.y,character.transform.position.z-DeltaZ);
				}
				
			}
			if(Input.GetKeyDown(KeyCode.S))
			{
				Debug.Log("Atras");
				tetha = 1-character.transform.rotation.y;
				Debug.Log(tetha);
			}
			if(Input.GetKeyDown(KeyCode.A))
			{
				Debug.Log("Izquierda");
			}
			if(Input.GetKeyDown(KeyCode.D))
			{
				Debug.Log("Derecha");
			}
			
	}

	
}
