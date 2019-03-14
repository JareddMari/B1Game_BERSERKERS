using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulet : MonoBehaviour {

    private Rigidbody r_Rigidbody;
    [SerializeField] private float Force = 20;

    private void Awake()
    {
        r_Rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        r_Rigidbody.AddForce(transform.forward * Force, ForceMode.Impulse);
    }
}