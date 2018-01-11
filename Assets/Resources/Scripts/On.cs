using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On : MonoBehaviour {

	public GameObject propeller;
	public GameObject blurpropeller;
	public GameObject AC130;
	private float acc=0;
	private float bluracc=0;
	private float velocidad;
	private float blurvelocidad;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		if (velocidad<20000.0)
		{
			acc += Time.deltaTime;
			velocidad = (acc * acc * acc);
			for (int i = 0; i < 4; i++) {
				propeller.transform.GetChild (i).localRotation = Quaternion.Euler (new Vector3 (0, velocidad, 0));
			}
		}
		else 
		{
			bluracc += Time.deltaTime;
			blurvelocidad = (bluracc * bluracc*2);
			propeller.SetActive (false);
			blurpropeller.SetActive (true);
			for (int i = 0; i < 4; i++) {
			blurpropeller.transform.GetChild (i).localRotation = Quaternion.Euler (new Vector3 (0, blurvelocidad, 0));
			}
		}
	}
}