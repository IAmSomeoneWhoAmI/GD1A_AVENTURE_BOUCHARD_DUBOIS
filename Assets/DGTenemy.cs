using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DGTenemy : MonoBehaviour
{
    public int Dmg = 1;
    private GameObject protags;

    void Start()
    {
        protags = GameObject.Find("Protags");
    }

    [System.Obsolete]
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Bouh"); // Debug message

            // Check if the "protags" GameObject has a health script
            hpplayer protagsHpScript = protags.GetComponent<hpplayer>();
            if (protagsHpScript != null)
            {
                protagsHpScript.TakeDamage(Dmg); // Call the TakeDamage method on "protags"
            }
            else
            {
                Debug.LogError("The 'protags' GameObject does not have an hpplayer script.");
            }
        }
        else
        {
            Debug.Log("Collision with non-Player object");
        }
    }
}
