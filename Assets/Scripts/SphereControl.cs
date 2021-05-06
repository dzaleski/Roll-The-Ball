using UnityEngine;

public class SphereControl : MonoBehaviour {

    int lay = 0;
    Rigidbody rb;
    bool raycast;

    private void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }
    void Update ()
    {
        ChangeLayer();
        AddTorque();        
    }

    void ChangeLayer()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            bool raycast = Physics.Raycast(transform.position, Vector3.left * 0.5f);
            if (raycast) lay = 1;
            else lay = 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            raycast = Physics.Raycast(transform.position, Vector3.right * 0.5f);
            if (raycast) lay = 0;
            else lay = 1;
            
        }

        Vector3 velocity = rb.velocity;
        float delta = rb.position.x - (lay * 1f - 0.5f);
        velocity.x = -delta * 5f;
        rb.velocity = velocity;                
    }

    void AddTorque()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector3.right;
        }

        rb.AddTorque(direction * 60f);
    }
}
