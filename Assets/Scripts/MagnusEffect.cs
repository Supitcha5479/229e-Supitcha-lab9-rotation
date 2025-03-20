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
            Kick(); //���¡��
            
        }
        ApplyEffect();

    }
    void Kick()
    {
        rb.linearVelocity = velocity; //����͹�����鹵ç
        rb.angularVelocity = spin; //�ç�Դ��ع
        ApplyEffect();

    }

    void ApplyEffect()
    { 
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity); //�ӹǳ

        rb.AddForce(magnusForce,ForceMode.Force); //����ç

    }
}
