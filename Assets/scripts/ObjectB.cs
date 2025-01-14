using UnityEngine;

public class ObjectB : MonoBehaviour
{
    public void ChangeColor()
    {
        
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    public void SetPosition(Transform source)
    {
        
        transform.position = source.position + Vector3.up;
    }

    public void HandleCustomData(ObjectA.CustomData data)
    {
        
        Debug.Log($"Received from {data.Name}: Position {data.Position}");
    }
}
