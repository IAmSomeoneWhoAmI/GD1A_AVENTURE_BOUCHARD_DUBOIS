using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Talk : MonoBehaviour
{
	public GameObject UI;
	public GameObject text;
	bool isTalking;
	


	// Start is called before the first frame update
	void Start()
	{
		
		UI.gameObject.SetActive(false);
		text.gameObject.SetActive(false);



	}

	// Update is called once per frame

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{

			text.gameObject.SetActive(true);
			isTalking = true;
			Time.timeScale = 0.0f;
		}

	}
    private void Update()
    {
		if (isTalking == true && Input.anyKeyDown)
			if (Input.GetKeyDown(KeyCode.DownArrow)) { }

			else if (Input.GetKeyDown(KeyCode.LeftArrow)) { }
			else if (Input.GetKeyDown(KeyCode.UpArrow)) { }
			else if (Input.GetKeyDown(KeyCode.RightArrow)) { }
			else

			{
			
			text.gameObject.SetActive(false);
				Destroy(gameObject);
				Time.timeScale = 1.0f;
				UI.gameObject.SetActive(true);
			}
	}
}




