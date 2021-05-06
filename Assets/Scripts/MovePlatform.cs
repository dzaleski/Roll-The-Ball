using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Vector3 delta;
    Vector3 startPosition;
    Rigidbody platformRb;

    void Start()
    {
        startPosition = transform.position;
        platformRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        PlatformMoving();
    }

    private void PlatformMoving()
    {
        float velocity = 40f / delta.sqrMagnitude;

        float change = (Mathf.Sin(Time.timeSinceLevelLoad * velocity) + 1f) / 2f;

        platformRb.MovePosition(Vector3.Lerp(startPosition, startPosition + delta, change));
    }
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.grey;

        Vector3 ghostSize = transform.rotation * transform.localScale * 2f;

        if (UnityEditor.Selection.activeTransform == transform)
        {
            Gizmos.color = Color.red;
        }
        Gizmos.DrawWireCube(transform.position + delta, ghostSize);
    }
    #endif
}
