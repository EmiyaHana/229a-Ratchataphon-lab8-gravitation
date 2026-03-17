using UnityEngine;

public class ChangeObjectColor : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Renderer>().material.color = Color.lightBlue;

        other.gameObject.GetComponent<Renderer>().material.color = Color.darkMagenta;
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.gold;

        other.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }
}