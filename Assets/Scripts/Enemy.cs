using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 50;
    //[SerializeField] private Transform enemyPos;
    [SerializeField] private GameObject dieVFX;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log($"{name} took {damage} damage!");

        if (health <= 0)
        {
            //ให้เสก VFX การตายของศัตรู และทำลาย VFX นั้นตามเวลาที่ต้องการ
            var dieVfx = Instantiate(dieVFX, transform.position, Quaternion.identity);
            Destroy(dieVfx, 1.5f);

            Destroy(gameObject, 0.5f);
        }
    }
}
