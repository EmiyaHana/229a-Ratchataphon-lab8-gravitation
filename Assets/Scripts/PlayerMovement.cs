using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 120f;
    public float jumpForce = 12f;

    Rigidbody rb;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Rotate();
        Jump();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        //Forward / Backward movement (W/S)
        //float v = Input.GetAxis("Vertical");
        float v = 0;
        if (Keyboard.current != null)
        {
            v = (Keyboard.current.wKey.isPressed ? 1f : 0) - (Keyboard.current.sKey.isPressed ? 1f :0);
        }
        
        Vector3 forwardMove = transform.forward * v * moveSpeed;
        rb.linearVelocity = new Vector3(forwardMove.x, rb.linearVelocity.y, forwardMove.z);
    }

    void Rotate()
    {
        //Left / Right rotation (A/D)
        //float h = Input.GetAxis("Horizontal");
        float h = 0;
        if (Keyboard.current != null)
        {
            h = (Keyboard.current.dKey.isPressed ? 1f : 0) - (Keyboard.current.aKey.isPressed ? 1f :0);
        }

        transform.Rotate(Vector3.up * h * rotateSpeed * Time.deltaTime);
    }

    void Jump()
    {
        bool jumpPressed = Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame;
        /*if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }*/
        if (jumpPressed && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
