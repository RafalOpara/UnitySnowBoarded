using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] float LefttorqueAmount=1f;
    [SerializeField] float RighttorqueAmount=-1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rb2b;

    SurfaceEffector2D surfaceEffector2D;
    bool canMove=true;
   
    void Start()
    {
        rb2b = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

   
    void Update()
    {
        if(canMove)
        {
        RotatePlayer();
        RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove=false;
    }

     void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed=boostSpeed; 
        }
        else
        {
            surfaceEffector2D.speed=baseSpeed;
        }
        
    }

    void RotatePlayer()
    {
            if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2b.AddTorque(LefttorqueAmount);
        }
         else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2b.AddTorque(RighttorqueAmount);
        }
    }


}
