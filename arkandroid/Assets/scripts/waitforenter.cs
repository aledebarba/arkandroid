using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waitforenter : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		// aguarda até o usuário pressionar enter
		if (Input.GetKeyDown ("return")) {
			SceneManager.LoadScene ("game");
		}
	}
}
