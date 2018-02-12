using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {

	public float velocidade;
	public bool inGame = false;
	public float posX;
	float screenCenter = 400;
	float direction = 0;

	void Update () {
		
		// trata se houver um toque na tela
		if (Input.touchCount > 0) {			
			if (Input.touches [0].position.x > screenCenter) {
				direction = 1.0f;	
			} 
			else if (Input.touches [0].position.x < screenCenter) {
				direction = -1.0f;
			}
			transform.Translate (direction * velocidade * Time.deltaTime, 0.0f, 0.0f);
		}

		// controle via teclado
		posX = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate (posX, 0.0f, 0.0f);
        
        // congela o jogador nos limites da tela 
		if ( transform.position.x<-2.7f ) { transform.position = new Vector3 (-2.7f, -3.761286f, 0.0f); } 
		if ( transform.position.x>2.7f )  { transform.position = new Vector3 (2.7f, -3.761286f, 0.0f); } 
	}
}
	

