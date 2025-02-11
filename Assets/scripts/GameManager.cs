using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PrefabDatabase prefabDatabase;
    [SerializeField] private Transform spownLocation;
    [SerializeField] private PrefabType typeToSpown;
    void Start()
    {
        GameObject randomPrefab = prefabDatabase.GetRandomPrefab();
        GameObject rp = Instantiate(randomPrefab, spownLocation.position, Quaternion.identity);
        ChangeColor(rp);

        for (int i = 0; i < prefabDatabase.prefabs.Length; i++)
        {
            if (prefabDatabase.prefabs[i].GetComponent<PrefabInfo>().prefabType == typeToSpown)
            {
                GameObject rpType = Instantiate(randomPrefab, spownLocation.position + Vector3.right * 2, Quaternion.identity);
                ChangeColor(rpType);
            }
        }
    }
    public void ChangeColor(GameObject GO)
    {

         GO.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}