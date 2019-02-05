using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationCanon : MonoBehaviour {

    public float speedRotation = 1f; // Variable de la vitesse de rotation
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("left"))
        {
            transform.Rotate(0, 0,-speedRotation ); // Rotation vers la gauche a la vitesse 1
        }
        if(Input.GetKey("right"))
        {
            transform.Rotate(0, 0, speedRotation); //Rotation vers la droite a la vitesse 1
            
        }

	}
    
}
//Je n'arrive pas a bloquer la rotation quand le game object atteind les 180° vous pensez pouvoir le faire ?

