using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Stalking : MonoBehaviour
{

    public float speed;
    public float range;
    private Transform player = null;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Vector3.Distance(player.position, gameObject.transform.position) <= range)

        {
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, player.position, speed * Time.deltaTime);

        }
    }
}
