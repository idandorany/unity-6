using UnityEngine;
using UnityEngine.Events;

public class ObjectA : MonoBehaviour
{
    
    public UnityEvent OnNoParamCollision;
    public UnityEvent<Transform> OnTransformCollision;
    public UnityAction OnActionCollision; 
    public UnityAction<Vector3> OnVectorCollision; 
    public UnityAction<CustomData> OnCustomCollision; 

    private void OnTriggerEnter(Collider other)
    {
        OnNoParamCollision?.Invoke();
        OnTransformCollision?.Invoke(transform);
        OnActionCollision?.Invoke();
        OnVectorCollision?.Invoke(transform.position);
        OnCustomCollision?.Invoke(new CustomData { Position = transform.position, Name = name });
    }

    public class CustomData
    {
        public Vector3 Position;
        public string Name;
    }
}
