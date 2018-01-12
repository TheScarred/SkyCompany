using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmFade : MonoBehaviour {

	public CanvasGroup button;
	public CanvasGroup image;
	public AudioSource mainmenu;
	public AudioClip menusong;
	private float waitTime=0;
	private float alpha=0;

	// Use this for initialization
	void Start () {
		mainmenu.PlayOneShot (menusong);
	}
	
	// Update is called once per frame
	void Update () {
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
}
