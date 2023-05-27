using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStableMovement : MonoBehaviour {
    public GameObject camera;
    private float badDegs = -1.0f;
    private float goodDegs = 1.0f;
    void Start() {
    }

    // Update is called once per frame
    void LateUpdate() {
        if (Input.GetKey("left") || (Input.GetKey("a"))) {
            for (var n = 0; n < 90; n++) {
                this.transform.Rotate(0, badDegs * Time.deltaTime, 0);
            }
        }

        if (Input.GetKey("right") || (Input.GetKey("d"))) {
            for (var m = 0; m < 90; m++) {
                this.transform.Rotate(0, goodDegs * Time.deltaTime, 0);
            }
        }

        if (Input.GetKey("up") || (Input.GetKey("w"))) {
            for (var m = 0; m < 90; m++) {
                // transform.Rotate(badDegs * Time.deltaTime, 0, 0);
                camera.transform.Rotate(badDegs * Time.deltaTime, 0, 0);
            }
        }

        if (Input.GetKey("down") || (Input.GetKey("s"))) {
            for (var m = 0; m < 90; m++) {
                camera.transform.Rotate(goodDegs * Time.deltaTime, 0, 0);
            }
        }
    }
}
