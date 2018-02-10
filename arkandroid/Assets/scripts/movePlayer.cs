using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {

	public float velocidade;
	public bool inGame = false;
	public float posX;

	void Update () {

		posX = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;

		transform.Translate (posX, 0.0f, 0.0f);

		if ( transform.position.x<-2.7f ) { transform.position = new Vector3 (-2.7f, -3.761286f, 0.0f); } 
		if ( transform.position.x>2.7f )  { transform.position = new Vector3 (2.7f, -3.761286f, 0.0f); } 
	}
}
	

