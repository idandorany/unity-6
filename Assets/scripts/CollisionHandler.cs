using UnityEngine;
using UnityEngine.Events;
using System;

public class CollisionHandler : MonoBehaviour
{
    
    public Action onCollisionAction;                      
    public Action<GameObject> onCollisionWithObject;      
    public Action<Vector3> onCollisionWithPosition;       

    
    public UnityEvent onCollisionUnityEvent;              
    public UnityEvent<GameObject> onCollisionWithObjectUnityEvent; 

    private void OnTriggerEnter(Collider other)
    {

        onCollisionAction?.Invoke();
        onCollisionWithObject?.Invoke(other.gameObject);
        onCollisionWithPosition?.Invoke(other.transform.position);

       
        onCollisionUnityEvent?.Invoke();
        onCollisionWithObjectUnityEvent?.Invoke(other.gameObject);
    }
}