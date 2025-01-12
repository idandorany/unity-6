using UnityEngine;

public class CubeColorChanger : MonoBehaviour
{
    public void ChangeColor(string colorName)
    {
        if (ColorUtility.TryParseHtmlString(colorName, out var color))
        {
            GetComponent<Renderer>().material.color = color;
        }
    }
}