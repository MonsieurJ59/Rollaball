using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            // Détruire le projectile lorsqu'il entre en collision avec un autre objet
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            // Détruire le projectile lorsqu'il entre en collision avec un autre objet
            Destroy(gameObject);
        }

        // Se détruire au bout de 2 secondes
        Destroy(gameObject, 2);
    }
}
