using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] private string targetSceneName;

    public GameObject title, protags, ui1, ui2, ui3, ui4, hp;
    // Start is called before the first frame update
    void Start()
    {
        title.gameObject.SetActive(true);
        protags.gameObject.SetActive(false);
        ui1.gameObject.SetActive(false);
        ui2.gameObject.SetActive(false);
        ui3.gameObject.SetActive(false);
        ui4.gameObject.SetActive(false);
        hp.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        { title.gameObject.SetActive(false);
            protags.gameObject.SetActive(true);
            ui1.gameObject.SetActive(true);
            ui2.gameObject.SetActive(false);
            ui3.gameObject.SetActive(false);
            ui4.gameObject.SetActive(false);
            hp.gameObject.SetActive(true);
            SceneManager.LoadScene(targetSceneName);
        }


    }
}
