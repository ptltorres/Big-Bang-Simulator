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
            Instantiate(bigBang, new Vector3(0f,0.5f,100f), Quaternion.identity);
        }
    }
}

