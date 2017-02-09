using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanel : MonoBehaviour {
    public float TitleSafeFactor = 0.1f;
    public float speed;

    // Update is called once per frame
    void Update () {
       // Do a raycast into the world that will only hit the Spatial Mapping mesh.
       var headPosition = Camera.main.transform.position;
       var gazeDirection = Camera.main.transform.forward;

        if (!IsTargetVisible()) {
            float step = Time.deltaTime * speed;
            this.transform.position = Vector3.MoveTowards(transform.position, headPosition + gazeDirection, step);

            // Rotate this object's parent object to face the user.
            Quaternion toQuat = Camera.main.transform.localRotation;
            toQuat.x = 0;
            toQuat.z = 0;
            this.transform.rotation = toQuat;
        }     
    }
 
    private bool IsTargetVisible() {
        // This will return true if the target's mesh is within the Main Camera's view frustums.
        Vector3 targetViewportPosition = Camera.main.WorldToViewportPoint(gameObject.transform.position);
        return (targetViewportPosition.x > TitleSafeFactor && targetViewportPosition.x < 1 - TitleSafeFactor &&
            targetViewportPosition.y > TitleSafeFactor && targetViewportPosition.y < 1 - TitleSafeFactor &&
            targetViewportPosition.z > 0);
    }
}

