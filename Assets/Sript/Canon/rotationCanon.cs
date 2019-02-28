using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationCanon : MonoBehaviour {

    public float speedRotation; // Variable de la vitesse de rotation
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("left"))
        {
            transform.Rotate(Vector3.forward * speedRotation * Time.deltaTime); // Rotation vers la gauche a la vitesse 1
        }
        if(Input.GetKey("right"))
        {
            transform.Rotate(Vector3.back * speedRotation * Time.deltaTime); //Rotation vers la droite a la vitesse 1
            
        }

	}
    
}


