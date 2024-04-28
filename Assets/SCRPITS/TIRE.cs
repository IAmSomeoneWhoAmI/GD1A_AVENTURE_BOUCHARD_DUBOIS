using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIRE : MonoBehaviour
{
    public Transform UpSpawn;
    public Transform DownSpawn;
    public Transform LeftSpawn;
    public Transform RightSpawn;
    public GameObject MusicNote;
    public float shotSpeed = 1f;
    public float noteRate = 2f;
    public float range = 1.5f;
    public bool canShoot = true;


    // Update is called once per frame
    void Update()
    {
        if (canShoot)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Shoot(UpSpawn, new Vector2(0, 1));
                Debug.Log("W");
            }
            //Left
            if (Input.GetKey(KeyCode.A))
            {
                Shoot(LeftSpawn, new Vector2(-1, 0));
                Debug.Log("A");
            }
            //Down
            if (Input.GetKey(KeyCode.S))
            {
                Shoot(DownSpawn, new Vector2(0, -1));
                Debug.Log("S");
            }
            //Right
            if (Input.GetKey(KeyCode.D))
            {
                Shoot(RightSpawn, new Vector2(1, 0));
                Debug.Log("D");
            }
        }
    }


    private void Shoot(Transform spawnPoint, Vector2 shootDirection)
    {
        canShoot = false;
        StartCoroutine(NoteRate());
        GameObject tears = Instantiate(MusicNote, spawnPoint.position, Quaternion.identity);
        tears.GetComponent<Rigidbody2D>().velocity = shootDirection * shotSpeed;
        tears.GetComponent<Notes>().timeToDeath = range;
        
    }

    IEnumerator NoteRate()
    {
        yield return new WaitForSeconds(1f / noteRate);
        canShoot = true;



    }
    
        
        
    
}

