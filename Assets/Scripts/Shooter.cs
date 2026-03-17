using UnityEngine;
using UnityEngine.InputSystem;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPos;
    public float shootForce;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, shootPos.position, shootPos.rotation);
        var rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shootPos.forward * shootForce, ForceMode.Impulse);
        Destroy(bullet, 3f);
    }
}
