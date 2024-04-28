using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSecret : MonoBehaviour
{
	
	public GameObject gridville;
	public GameObject gridforet;
	public GameObject gridgrotte;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		Scene scene = SceneManager.GetActiveScene();

		if (scene.name == "ville")
			gridville.gameObject.SetActive(true);
		gridforet.gameObject.SetActive(false);
		gridgrotte.gameObject.SetActive(false);

		if (scene.name == "foret")
			gridville.gameObject.SetActive(false);
		gridforet.gameObject.SetActive(true);
		gridgrotte.gameObject.SetActive(false);

		if (scene.name == "grotte")
			gridville.gameObject.SetActive(false);
		gridforet.gameObject.SetActive(false);
		gridgrotte.gameObject.SetActive(true);

		if (Input.GetKey(KeyCode.I))
			gridville.gameObject.SetActive(false);
		gridforet.gameObject.SetActive(false);
		gridgrotte.gameObject.SetActive(false);
	}
}
