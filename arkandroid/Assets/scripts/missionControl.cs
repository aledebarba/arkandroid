using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missionControl : MonoBehaviour {

	//variáveis globais
	public static bool okToGo = false;
	public static float countDown = 5.0f;

	// comṕonentes
	Text txtCounter;
	Image imgInstrucoes;

	// Use this for initialization
	void Start () {
		// referencia o componente de texto
		imgInstrucoes = GameObject.Find("instrucoes").GetComponent<Image>();
		txtCounter = GameObject.Find("txtContador").GetComponent<Text>();
		// inicia a contagem regressiva
		StartCoroutine(CountDown());
	}

	IEnumerator CountDown(){
		float counter = countDown;
		while (counter > -1) {
			txtCounter.text = counter.ToString ();
			counter--;
			yield return new WaitForSeconds(1.0f);
		}
		// sinaliza com okToGo que o contador acabou e que o jogo pode prosseguir
		okToGo = true;
		txtCounter.enabled = false;
		imgInstrucoes.enabled = false;
	}	

	// Update is called once per frame
	void Update () {
		
	}
}
