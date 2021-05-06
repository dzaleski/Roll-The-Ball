using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] int moveUpSpeed;
    private void OnTriggerStay(Collider other)
    {
        MoveUp(other);
    }

    private void MoveUp(Collider other)
    {
        Rigidbody rigidbody = other.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;
        velocity.y = moveUpSpeed;
        velocity.z = moveUpSpeed / 2;
        rigidbody.velocity = velocity;
    }
}
