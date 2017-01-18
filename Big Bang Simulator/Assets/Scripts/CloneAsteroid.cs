using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneAsteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Clone", Random.Range(1f, 5f));
        Destroy(gameObject, 20f);
    }
	
	void Clone() {
        string AsteroidName = "Asteroid" + Random.Range(1, 4);
        Debug.Log(AsteroidName);

        var randomRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        Instantiate(Resources.Load(AsteroidName), new Vector3(Random.Range(-40, 40), Random.Range(-40, 40), Random.Range(-40, 40)), randomRotation);
    }
}
