using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viseurCanon : MonoBehaviour {

    private float dist;
    private Vector3 aimPoint;
    private Vector3 desiredShot;
    
    public Object Canon;
    Plane Murtest;
	// Use this for initialization
	void Start ()
    {
             
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // crée un rayon à partir de la sourisPosition

            if (Murtest.Raycast(ray,out dist)) // dist est un nombre à virgule flottante allant du début du rayon au point de vie
            {
                aimPoint = ray.GetPoint(dist); // aimPoint est un vecteur 3 décrivant le survol de la souris
                desiredShot = aimPoint - transform.position; // désiréeShot est un vecteur3 entre notre curseur de souris et le canon faisant le coup
                desiredShot.z = 0; // nous laisse juste X, Y
            }
    

    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
