using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icurse : MonoBehaviour
{
    private GameObject Emo;
    public GameObject secret; 

    void Start()
    {
        
        
        
    }

    void Update()
    {
        Emo = GameObject.Find("Emo");
        Debug.Log("Bouh");

        // Check if 'Emo' is not null (i.e., it exists in the scene)
        if (Emo != null)
        {
            Debug.Log("ALED");
            if (Emo.activeSelf)
            {
                Debug.Log("actif");
                secret.SetActive(false);
            }
            else 
            {
                Debug.Log("inactif");
                secret.SetActive(true);
            }
        }
        else
        {
            Debug.Log("inactif");
            secret.SetActive(true);
        }

    }
}

