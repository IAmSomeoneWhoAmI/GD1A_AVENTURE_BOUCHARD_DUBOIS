using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMORE : MonoBehaviour
{
    private hpplayer currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        Destroy(gameObject);
    }
}

}
