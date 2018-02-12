using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waitforenter : MonoBehaviour {

	public float secondsToAvoidTaps = 5.0f;
	bool okTaps;

	void Start(){
		okTaps = false;
		StartCoroutine (PausaDeteccaoDeTaps ());
	}

	IEnumerator PausaDeteccaoDeTaps(){
		yield return new WaitForSeconds(secondsToAvoidTaps);
		okTaps = true;
	}
	// Update is called once per frame
	void Update () {

		// aguarda até o usuário pressionar enter ou tocar na tela
		if (Input.GetKeyDown ("return") || (okTaps && Input.touchCount>0)) {
			SceneManager.LoadScene ("game");
		}  
	}
}
