using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterMovementScript : MonoBehaviour
{
    public CharacterController2D controller;
    public float horizontalMove = 0f;
    public float runSpeed = 40f;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;     
    }

    void FixedUpdate(){
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }

}
