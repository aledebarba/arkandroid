﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class androidCollide : MonoBehaviour {

	static int androids;

	void Start () {
		androids = 12;
	}

	void OnCollisionEnter2D(Collision2D c) {
		// Destroi os androids e reduz o contador
		Destroy (gameObject);
		androids--;
		// quando o contador zerar, carrega endgame
		if (androids <= 0) {
			// garante que o contador e as intruções do canvas vão aparecer se o jogo reiniar
			missionControl.okToGo = false;
			// carrega fim de jogo
			SceneManager.LoadScene ("endgame");
		}
	}
}
