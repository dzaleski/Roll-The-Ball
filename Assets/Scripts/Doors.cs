using UnityEngine;

public class Doors : MonoBehaviour
{
    public HingeJoint doorsJoint;
    
    private void OnTriggerStay(Collider other)
    {
        if (CollideWithSphere(other))
        {
            OpenDoors();
        }
    }

    private static bool CollideWithSphere(Collider other)
    {
        return other.CompareTag("Sphere");
    }

    private void OpenDoors()
    {
        JointMotor jm = doorsJoint.motor;
        jm.targetVelocity = 100;
        doorsJoint.motor = jm;
    }
    private void OnTriggerExit(Collider other)
    {
        if (CollideWithSphere(other))
        { 
            CloseDoors();
        }
    }
    private void CloseDoors()
    {
        JointMotor jm = doorsJoint.motor;
        jm.targetVelocity = -100;
        doorsJoint.motor = jm;
    }
}
