using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torque; //‰«È°”Àπ¥„πUnity

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        { 
        rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1)) 
        { rb.AddTorque(torque);}
        else if (Input.GetKeyDown(KeyCode.Z)) 
        { 
            rb.angularVelocity = Vector3.zero;

        }
    }
}
