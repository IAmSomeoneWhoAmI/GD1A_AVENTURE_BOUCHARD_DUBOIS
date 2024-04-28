using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuageToxic : MonoBehaviour

{
    public string targetTag = "nuage"; // Set the tag you want to ignore collisions with

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))

        {
            Debug.Log("ok");
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }


    }
}

