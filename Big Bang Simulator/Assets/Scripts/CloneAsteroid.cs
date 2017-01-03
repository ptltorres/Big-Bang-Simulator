using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneAsteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            var randomRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            Instantiate(Resources.Load("Asteroid"), new Vector3(Random.Range(-40, 40), Random.Range(-40, 40), Random.Range(-40, 40)), randomRotation);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
