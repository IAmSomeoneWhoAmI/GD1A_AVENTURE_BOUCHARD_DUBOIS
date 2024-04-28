using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Material hit;
    private SpriteRenderer thisSprite;
    private Material chacheSprite;
    public bool isHiting;
    public float Hitingcounter;
    public float hitingLenght;
    private GameObject HP;





    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        thisSprite = GetComponent<SpriteRenderer>();
        chacheSprite = thisSprite.material;
        HP = GameObject.Find("1HP");
    }

    // Update is called once per frame
    void Update()
    {
        if (isHiting)
        {
            thisSprite.material = hit;
            if (Hitingcounter <= 0)
            {
                Hitingcounter = hitingLenght;
            }
            isHiting = false;


        }
        if (Hitingcounter > 0)
        {
            Hitingcounter -= Time.fixedDeltaTime;

            if (Hitingcounter < 0)
            {
                thisSprite.material = chacheSprite;
            }
        }
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;        
        
        isHiting = true;        

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            if (HP != null)
        {
            Instantiate(HP, transform.position, Quaternion.identity);
        }
    }
        }
    
            
        

    }


