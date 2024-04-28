using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyatk : MonoBehaviour
{

    public float speed;
    public float range;
    public float stop;
    public float retreat;
    

    private float timeBtwShot;
    public float startTimeBtwShot;

    private Transform player = null;
    public GameObject OrbEnemy;
    
    
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        timeBtwShot = startTimeBtwShot;
    }

    
    void Update()
    {
        player = GameObject.FindWithTag("Player").transform;
        if (Vector3.Distance(player.position, transform.position) <= range)

        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector3.Distance(player.position, transform.position) >= stop && Vector3.Distance(player.position, transform.position) >= retreat)
        {
            transform.position = this.transform.position;
        }
        else if (Vector3.Distance(player.position, transform.position) >= retreat) 
        { transform.position = Vector3.MoveTowards(transform.position, player.position, - speed * Time.deltaTime); 
        }

        if (Vector3.Distance(player.position, transform.position) <= range)
            if (timeBtwShot <=0) {

            Instantiate(OrbEnemy, transform.position, Quaternion.identity) ;
            timeBtwShot = startTimeBtwShot;
        } else
        {
            timeBtwShot -= Time.deltaTime;

        }


    }

}
