using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueControl : MonoBehaviour
{
    public float torquePower = 1f;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            _rb.AddTorque(0, torquePower, 0);
        }
    }
}
