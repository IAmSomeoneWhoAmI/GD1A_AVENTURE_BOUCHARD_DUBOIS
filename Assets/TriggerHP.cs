using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHP : MonoBehaviour
{
    public GameObject Trigger;
    // Start is called before the first frame update
    void Start()
    {
        Trigger.gameObject.SetActive(true);
    }

    // Update is called once per frame
void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("HP"))
    {
        Trigger.gameObject.SetActive(false);
        StartCoroutine(ReactivateTrigger());
    }
}

IEnumerator ReactivateTrigger()
{
    yield return new WaitForSeconds(0.1f); // Wait for 0.1 seconds
    Trigger.gameObject.SetActive(true);
}
}