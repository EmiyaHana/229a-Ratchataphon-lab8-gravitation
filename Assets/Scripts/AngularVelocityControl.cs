using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocityControl : MonoBehaviour
{
    public float angularSpeed = 1;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            _rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }
        else
        {
            _rb.angularVelocity = Vector3.zero;
        }
    }
}