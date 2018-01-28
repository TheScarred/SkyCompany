using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class canvas : MonoBehaviour {

	public Image ui;
	public Sprite[] crosshairs;

	// Use this for initialization
	void Start () {
		this.GetComponent<Image> ().sprite = crosshairs [0];
		Quaternion rot = transform.localRotation;
	}
	void Update () {

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			ui.sprite = crosshairs [0];
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			ui.sprite = crosshairs [1];
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			ui.sprite = crosshairs [2];
		}
	}
}
