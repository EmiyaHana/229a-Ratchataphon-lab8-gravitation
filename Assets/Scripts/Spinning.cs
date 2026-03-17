using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] private float tourque = 5;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddTorque(0, tourque, 0);
    }
}
