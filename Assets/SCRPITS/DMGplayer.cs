using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMGplayer : MonoBehaviour
{
    public int Dmg = 3;
    
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Bouh");
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(Dmg);
            Destroy(gameObject);

        }
    }
}
