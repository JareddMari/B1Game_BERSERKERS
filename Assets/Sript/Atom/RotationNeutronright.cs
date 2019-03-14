using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationNeutronright : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 50f;
    [HideInInspector]
    public bool isPaused = false;
    public KeyCode pauseKey;

    public enum StartState { Rotate, Invert, Paused }
    public StartState rotateState;
    // Use this for initialization
    void Start()
    {
        switch (rotateState)
        {
            case StartState.Invert:
                rotationSpeed = -rotationSpeed;
                break;
            case StartState.Paused:
                isPaused = true;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            ToggleRotationPause();
        }
        if (!isPaused)
        {
            transform.Rotate(Vector3.left, Time.deltaTime * rotationSpeed);
        }
    }
    public void ToggleRotationPause()
    {
        isPaused = !isPaused;
    }

}
