using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static Vector3 TempPosition;
    public Transform player;
    [SerializeField] private string targetSceneName;
    public Transform spawnPoint;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        TempPosition = player.transform.position;
    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(targetSceneName);
            player.transform.position = TempPosition;
            GameObject.FindWithTag("Player").transform.position = spawnPoint.position;
        }
        

    }
    }




