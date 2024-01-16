using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{   
    [SerializeField] InputAction movement;

    void Start()
    {
        
    }

    void Update()
    {
        /*float horizontalThrow = Input.GetAxis("Horizontal");
        float verticalThrow = Input.GetAxis("Vertical");

        Debug.Log(horizontalThrow);
        Debug.Log(verticalThrow);*/
    }
}