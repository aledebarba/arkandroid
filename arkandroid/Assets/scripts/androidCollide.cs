using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class androidCollide : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c) {
		Destroy (gameObject);

	}
}
