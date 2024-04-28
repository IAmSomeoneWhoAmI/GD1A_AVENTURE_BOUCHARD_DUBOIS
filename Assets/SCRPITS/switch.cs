using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchCharacterScript : MonoBehaviour

{






	// referenses to controlled game objects
	public GameObject avatar1, avatar2, avatar3, avatar4, UI1, UI2, UI3, UI4; 
	

	// variable contains which avatar is on and active


	// Use this for initialization
	void Start()
	{


		avatar1.gameObject.SetActive(true);
		avatar2.gameObject.SetActive(false);
		avatar3.gameObject.SetActive(false);
		avatar4.gameObject.SetActive(false);
		UI1.gameObject.SetActive(true);
		UI2.gameObject.SetActive(false);
		UI3.gameObject.SetActive(false);
		UI4.gameObject.SetActive(false);
		






	}

	// public method to switch avatars by pressing UI button
	void Update()

	{
		


		if (UI2.activeInHierarchy == true)
		{
			if (Input.GetKeyDown(KeyCode.I))
			{
				Debug.Log("I");

				if (avatar2.activeInHierarchy == false)
					if (avatar1.activeInHierarchy == true)
						avatar2.transform.position = avatar1.transform.position;
				if (avatar3.activeInHierarchy == true)
					avatar2.transform.position = avatar3.transform.position;
				if (avatar4.activeInHierarchy == true)
					avatar2.transform.position = avatar4.transform.position;
				avatar1.gameObject.SetActive(false);
				avatar3.gameObject.SetActive(false);
				avatar4.gameObject.SetActive(false);
				avatar2.gameObject.SetActive(true);
				

				avatar2.gameObject.GetComponent<TIRE>().canShoot = true;


			}

		}

		if (Input.GetKeyDown(KeyCode.U))
		{
			Debug.Log("U");
			if (avatar1.activeInHierarchy == false)
				if (avatar2.activeInHierarchy == true)
					avatar1.transform.position = avatar2.transform.position;
			if (avatar3.activeInHierarchy == true)
				avatar1.transform.position = avatar3.transform.position;
			if (avatar4.activeInHierarchy == true)
				avatar1.transform.position = avatar4.transform.position;

			avatar1.gameObject.SetActive(true);
			avatar3.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			



			avatar1.gameObject.GetComponent<TIRE>().canShoot = true;



		}
		if (UI3.activeInHierarchy == true)
		{
			if (Input.GetKeyDown(KeyCode.O))
			{
				Debug.Log("O");
				if (avatar3.activeInHierarchy == false)
					if (avatar1.activeInHierarchy == true)
						avatar3.transform.position = avatar1.transform.position;
				if (avatar2.activeInHierarchy == true)
					avatar3.transform.position = avatar2.transform.position;
				if (avatar4.activeInHierarchy == true)
					avatar3.transform.position = avatar4.transform.position;
				avatar3.gameObject.SetActive(true);
				avatar1.gameObject.SetActive(false);
				avatar2.gameObject.SetActive(false);
				avatar4.gameObject.SetActive(false);
				


				avatar3.gameObject.GetComponent<TIRE>().canShoot = true;


			}
			if (UI4.activeInHierarchy == true)
			{
				if (Input.GetKeyDown(KeyCode.P))
				{
					Debug.Log("P");
					if (avatar4.activeInHierarchy == false)

						if (avatar1.activeInHierarchy == true)
							avatar4.transform.position = avatar1.transform.position;
					if (avatar3.activeInHierarchy == true)
						avatar4.transform.position = avatar3.transform.position;
					if (avatar2.activeInHierarchy == true)
						avatar4.transform.position = avatar2.transform.position;
					avatar4.gameObject.SetActive(true);
					avatar1.gameObject.SetActive(false);
					avatar2.gameObject.SetActive(false);
					avatar3.gameObject.SetActive(false);
					


					avatar4.gameObject.GetComponent<TIRE>().canShoot = true;








				}

			}


		}
	}
}

	
	




