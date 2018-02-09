using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class On : MonoBehaviour {

	public GameObject propeller;
	public GameObject blurpropeller;
	public GameObject AC130;
	public AudioSource gunship;
	public AudioClip startup;
	private float acc=0;
	private float bluracc=0;
	private float startacc=0;
	private float velocidad;
	private float blurvelocidad;
	private float startvelocidad;
	public bool gamestart=false;

	// Use this for initialization
	void Start () {
		gunship.PlayOneShot (startup);
	}

	// Update is called once per frame
	void Update () {

		if (velocidad<12500.0)
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
		if (gamestart) {
			gunship.Stop ();
			startacc += Time.deltaTime;
			startvelocidad = ((startacc * startacc) / 2);
			this.transform.position = new Vector3 (10.0f-startvelocidad, 5.7f, -0.7f); 
			if (startvelocidad > 30.0f) {
				gamestart = false;
			}
		}
		if (AC130.transform.position.x < -20.0f) {
			EditorSceneManager.LoadScene ("game");
		}
	}
	public void start()
	{
		gamestart = true;
	}
}