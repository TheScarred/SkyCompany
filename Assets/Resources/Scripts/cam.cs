using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {

	public float velocidad;
	float izqder;
	float arraba;

	void Update()
	{
		izqder = Input.GetAxis ("Vertical");
		arraba = Input.GetAxis ("Horizontal");

		if (izqder != 0) {
			rotarx ();
		}
		if (arraba != 0) {
			rotary ();
		}
	}
	void rotarx(){
		if ((this.transform.rotation.eulerAngles.y > 50.0f) && (this.transform.rotation.eulerAngles.y < 250.0f)) {
			this.transform.Rotate (new Vector3 (-1 * velocidad * izqder * Time.deltaTime, 0f, 0f));
		}
	}
	void rotary(){
		this.transform.Rotate (new Vector3 (0f, velocidad * arraba * Time.deltaTime, 0f));
	}
}
