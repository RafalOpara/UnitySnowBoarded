using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] float LefttorqueAmount=1f;
    [SerializeField] float RighttorqueAmount=-1f;
    Rigidbody2D rb2b;
    // Start is called before the first frame update
    void Start()
    {
        rb2b = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
