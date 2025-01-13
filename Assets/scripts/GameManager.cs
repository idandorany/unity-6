using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PrefabDatabase prefabDatabase;

    void Start()
    {
        var randomPrefab = prefabDatabase.GetRandomPrefab();
        Instantiate(randomPrefab, Vector3.zero, Quaternion.identity);

        var specificPrefab = prefabDatabase.GetPrefabByType(PrefabType.TypeA);
        if (specificPrefab != null)
        {
            Instantiate(specificPrefab, Vector3.right * 2, Quaternion.identity);
        }
    }
}