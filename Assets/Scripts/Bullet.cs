using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float force = 5;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(-force, 0, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddTorque(0, 10, 0);
    }
}