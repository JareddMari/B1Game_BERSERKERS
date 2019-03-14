using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panpan : MonoBehaviour {
    public GameObject Projectil;
    [SerializeField] private Transform Cube;
    public int force = 1; 
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        Boulet boulet = FindObjectOfType<Boulet>();
        if (boulet == null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject Boule = Instantiate(Projectil, Cube.position, Cube.rotation) as GameObject;

            }
        }
    }
}