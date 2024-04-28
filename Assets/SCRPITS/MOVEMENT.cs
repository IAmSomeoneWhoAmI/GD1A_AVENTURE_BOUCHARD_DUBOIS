using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEMENT : MonoBehaviour
{
    public float moveSpeed = 3f;
    void Start()
    {

    }


    void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = (transform.right * Time.deltaTime * -moveSpeed).x;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = (transform.right * Time.deltaTime * moveSpeed).x;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y = (transform.up * Time.deltaTime * moveSpeed).y;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = (transform.up * Time.deltaTime * -moveSpeed).y;
        }

        movement = movement + (Vector2)(transform.position);

        GetComponent<Rigidbody2D>().MovePosition(movement);

    }
}
