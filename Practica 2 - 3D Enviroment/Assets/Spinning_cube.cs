using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning_cube : MonoBehaviour
{
	
	private Collectable cube;
	private bool collider = false;
	
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponentInChildren<Collectable>();
		cube.GetComponent<Renderer>().material.color = Color.red;
		collider = false;
    }

    // Update is called once per frame
    void Update()
    {
		
        if(collider && Input.GetKeyDown(KeyCode.E))
		{
			
			cube.GetComponent<Renderer>().material.color = Color.white;
						
		}
    
	}


	void OnTriggerEnter()
	{
		collider = true;
		Debug.Log("Cube");
		cube.GetComponent<Renderer>().material.color = Color.green;
	}
	
	void OnTriggerExit()
	{
		collider = false;
		//cube.GetComponent<Renderer>().material.color = Color.red;
	}
	
}
