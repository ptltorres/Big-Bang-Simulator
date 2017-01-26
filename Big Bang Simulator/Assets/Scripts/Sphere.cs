using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
    public GameObject bigBang;

	public void Explode() {
        Instantiate(bigBang, gameObject.transform.position, Quaternion.identity);
        Debug.Log("Object created");
        Destroy(gameObject);
    }

}
