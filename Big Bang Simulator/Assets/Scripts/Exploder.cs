using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour {
    public GameObject bigBang;
    private static bool exploded = false;

    public void OnSelect() {
        if (!exploded) {
            Destroy(gameObject);
            exploded = true;
            Instantiate(bigBang, new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity);
        }
    }
}

