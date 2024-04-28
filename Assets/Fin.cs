using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fin : MonoBehaviour
{
    private GameObject fin;
    // Start is called before the first frame update
    void Start()
    {
        fin = GameObject.Find("Fin");
        fin.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            fin.SetActive(true);
            Time.timeScale = 0.0f;
        }

    }
}
