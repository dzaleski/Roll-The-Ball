using System;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public int cameraSpeed;
    public Vector3 cameraOffset;
    public Vector3 cameraRotation;

    [NonSerialized]
    public Rigidbody sphereRigidbody;

    void Update()
    {
        Vector3 newPos = sphereRigidbody.position + cameraOffset;
        transform.position = Vector3.Lerp(transform.position, newPos, cameraSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(cameraRotation);
	}
}

