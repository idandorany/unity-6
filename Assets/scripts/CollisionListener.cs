using UnityEngine;

public class CollisionListener : MonoBehaviour
{
    public CollisionHandler collisionHandler;

    private void Start()
    {
        if (collisionHandler != null)
        {
            collisionHandler.onCollisionAction += HandleCollision;
            collisionHandler.onCollisionWithObject += HandleCollisionWithObject;
            collisionHandler.onCollisionWithPosition += HandleCollisionWithPosition;
        }
    }

    private void HandleCollision()
    {
        Debug.Log("Collision detected!");
    }

    private void HandleCollisionWithObject(GameObject obj)
    {
        Debug.Log($"Collision with: {obj.name}");
    }

    private void HandleCollisionWithPosition(Vector3 position)
    {
        Debug.Log($"Collision at position: {position}");
    }

    private void OnDestroy()
    {
        if (collisionHandler != null)
        {
            collisionHandler.onCollisionAction -= HandleCollision;
            collisionHandler.onCollisionWithObject -= HandleCollisionWithObject;
            collisionHandler.onCollisionWithPosition -= HandleCollisionWithPosition;
        }
    }
}