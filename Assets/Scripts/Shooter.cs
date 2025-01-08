using Unity.Mathematics;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab; // Le prefab du projectile
    public float projectileSpeed = 10f; // Vitesse du projectile
    public float gap = 0.5f; // Espace entre le joueur et le projectile

    void Update()
    {
        // Détecter la touche pour tirer
        if (Input.GetKeyDown(KeyCode.W))
        {
            FireProjectile(new Vector3(0, 0, 1));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            FireProjectile(new Vector3(-1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            FireProjectile(new Vector3(0, 0, -1));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            FireProjectile(new Vector3(1, 0, 0));
        }
    }

    void FireProjectile(Vector3 direction)
    {
        
        // Créer le projectile à partir du FirePoint
        GameObject projectile = Instantiate(projectilePrefab, transform.position + (direction * gap), quaternion.identity);

        // Ajouter une vitesse au projectile
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = direction * projectileSpeed;
        }
    }
}
