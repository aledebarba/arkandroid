using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bolaColisao : MonoBehaviour {


	public float rotacao =360.0f;
	public float velX, velY;
	public AudioClip somBottom;

	SpriteRenderer rnd;
	AudioSource audioSrc;

	void Start() {
		audioSrc = GetComponent<AudioSource> ();
		rnd = GetComponent<SpriteRenderer> ();
	}

	void Update () {

		transform.Translate (velX * Time.deltaTime,  velY * Time.deltaTime, 0.0f);

			
	}

	void OnCollisionEnter2D(Collision2D c){
	
		// se tocar em qualquer coisa que não sejam as laterais, inverte a direção do movimento
		if (!(c.gameObject.tag == "bound")) {
			velY *= -1;
			audioSrc.Play ();
		} else {
			velX *= -1;
			audioSrc.Play ();
		}

		// se tocar no player, altera o vetor de X
		if (c.gameObject.tag == "Player") {
			velX = 0;
			while (velX==0) {velX = Random.Range (-3, 3);}
			rnd.flipX = !rnd.flipX;
			audioSrc.Play ();

		}

		if (c.gameObject.tag == "bottom") {
			audioSrc.PlayOneShot (somBottom, 1);
			SceneManager.LoadScene ("Start");
			
		}
	}
}
