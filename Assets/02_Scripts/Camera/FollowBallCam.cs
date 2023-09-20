using System;
using UnityEngine;

public class FollowBallCam : MonoBehaviour {
    Camera camera;

    private void Awake() {
        camera = GetComponent<Camera>();
    }

    private void Update() {
        FollowBall();
    }

    private void FollowBall() {
        Debug.Log("follow ball");
        camera.transform.position = transform.position;
    }
}
