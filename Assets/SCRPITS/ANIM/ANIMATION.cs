using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANIMATION : MonoBehaviour
{

    public Transform up;
    public Transform down;
    public Transform left;
    public Transform right;
    public Transform idle;
    public GameObject May;

    Animator anim;

    

    void Start()
    {
        anim = this.GetComponent<Animator>();
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            May.GetComponent<Animator>().Play("UP");
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            May.GetComponent<Animator>().Play("DOWN");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            May.GetComponent<Animator>().Play("LEFT");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            May.GetComponent<Animator>().Play("RIGHT");
        }
        else
        {
            May.GetComponent<Animator>().Play("IDLE");
        }





    }
}