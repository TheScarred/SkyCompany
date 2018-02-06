using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimatePooling;

public class gunship : MonoBehaviour {

	public Transform spawnpoint;
	public Transform flarepoint;
	public Camera cam;
	float giro;
	float tiempo=0;
	float x,y=500,z;
	public float radio;
	public float velocidad;
	private bool main=true;
	private bool sec=false;
	private bool mini=false;
	// Use this for initialization
	void Start () {
		giro = 360 / -130f;
	}
	
	// Update is called once per frame
	void Update () {
		///rotacion
		tiempo += Time.deltaTime * velocidad;
		x = radio * Mathf.Cos (tiempo);
		z = radio * Mathf.Sin (tiempo);
		transform.position = new Vector3 (1250+x, y, 1250+z);
		transform.Rotate (0f, 0f, giro * Time.deltaTime);

		///helices


		///camaras
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			cam.fieldOfView = 90;
			main = true;
			sec = false;
			mini = false;

		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			cam.fieldOfView = 60;
			main = false;
			sec = true;
			mini = false;
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			cam.fieldOfView = 30;
			main = false;
			sec = false;
			mini = true;
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			UltimatePool.spawn (Resources.Load<GameObject>("Art/flare"), flarepoint.position, flarepoint.rotation);
		}

		if (main) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				UltimatePool.spawn (Resources.Load<GameObject>("Art/120mm"), spawnpoint.position, new Quaternion (spawnpoint.rotation.x, spawnpoint.rotation.y, spawnpoint.rotation.z - 90, 0f));
				StartCoroutine (bigbig ());
			}
		}
		if (sec) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				UltimatePool.spawn (Resources.Load<GameObject>("Art/80mm"), spawnpoint.position, new Quaternion (spawnpoint.rotation.x, spawnpoint.rotation.y, spawnpoint.rotation.z - 90, 0f));
				StartCoroutine (medmed ());
				}
			}
		if (mini)
			{
				if (Input.GetKey(KeyCode.Space)){
				UltimatePool.spawn (Resources.Load<GameObject>("Art/30mm"), spawnpoint.position, new Quaternion (spawnpoint.rotation.x, spawnpoint.rotation.y, spawnpoint.rotation.z - 90, 0f));
					StartCoroutine (tinytiny());
				}
			}
		}
	IEnumerator bigbig()
	{
		yield return new WaitForSeconds (5f);
	}
	IEnumerator medmed()
	{
		yield return new WaitForSeconds (2f);
	}
	IEnumerator tinytiny()
	{
		yield return new WaitForSeconds (0.1f);
	}
}
