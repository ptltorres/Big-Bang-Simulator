using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {
    public float moveSpeed = 10f;


	// Use this for initialization
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}
}
