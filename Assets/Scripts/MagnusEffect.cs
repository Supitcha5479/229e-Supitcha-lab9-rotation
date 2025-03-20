using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick(); //เรียกใช้
            
        }
        ApplyEffect();

    }
    void Kick()
    {
        rb.linearVelocity = velocity; //เคลื่อนที่เส้นตรง
        rb.angularVelocity = spin; //แรงบิดหมุน
        ApplyEffect();

    }

    void ApplyEffect()
    { 
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity); //คำนวณ

        rb.AddForce(magnusForce,ForceMode.Force); //ใส่แรง

    }
}
