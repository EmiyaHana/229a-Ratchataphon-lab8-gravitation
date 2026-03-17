using UnityEngine;
public class AddForce : MonoBehaviour
{
    public float force;
    public float mass;
    public float accel;

    void CalculateForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        force = mass * accel;
        GetComponent<Rigidbody>().AddForce(force, force, 0);
    }

    public void SetAccel250()
    {
        accel = 250f;
        CalculateForce();
    }

    public void SetAccel3000()
    {
        accel = 300f;
        CalculateForce();
    }

    public void SetAccel350()
    {
        accel = 350f;
        CalculateForce();
    }
}