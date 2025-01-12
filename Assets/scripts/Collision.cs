using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public float damage = 20f;

    private void OnTriggerEnter(Collider other)
    {
        
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage); 
        }
    }
}