using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StartBigBang : MonoBehaviour {


	public ParticleSystem BigBangInitial;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void toggleOnOff(){
		//BigBangInitial.gameObject.SetActive(BigBangInitial.gameObject.activeSelf);
		if (BigBangInitial.isPlaying) {
			BigBangInitial.Stop ();
		} else {
			BigBangInitial.Play ();
		}
	}

}
