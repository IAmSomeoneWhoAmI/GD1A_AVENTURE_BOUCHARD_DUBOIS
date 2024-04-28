using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orb_nuage_trigger : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "nuage")
        {
            this.gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        }
    }
}
