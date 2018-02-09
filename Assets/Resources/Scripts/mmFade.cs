using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmFade : MonoBehaviour {
	public GameObject AC130;
	public GameObject boton;
	public CanvasGroup button;
	public CanvasGroup image;
	public AudioSource mainmenu;
	public AudioClip menusong;
	private float waitTime=0;
	private float alpha=0;
	private bool starto = false;

	// Use this for initialization
	void Start () {
		mainmenu.PlayOneShot (menusong);
	}
	
	// Update is called once per frame
	void Update () {

		if (starto == false) {
			if (waitTime < 23.0) {
				waitTime += Time.deltaTime;
			} else {
				if (alpha < 1.0) {
					alpha += (Time.deltaTime / 4);
					button.alpha = alpha;
					image.alpha = alpha;
				}
			}
		}
		if (AC130.transform.position.x < 9.5) {
			starto = true;
			if (alpha > 0) {
				alpha -= (Time.deltaTime / 2);
				button.alpha = alpha;
				image.alpha = alpha;
			}
		}
	}
}
