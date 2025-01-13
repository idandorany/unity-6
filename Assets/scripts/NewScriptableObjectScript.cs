using UnityEngine;

[CreateAssetMenu(fileName = "PrefabDatabase", menuName = "ScriptableObjects/PrefabDatabase")]
public class PrefabDatabase : ScriptableObject
{
    public GameObject[] prefabs;
    public PrefabData linkedPrefabData;

    public GameObject GetRandomPrefab()
    {
        int index = Random.Range(0, prefabs.Length);
        return prefabs[index];
    }

    public GameObject GetPrefabByType(PrefabType type)
    {
        foreach (var prefab in prefabs)
        {
            if (prefab.name.Contains(type.ToString()))
                return prefab;
        }
        return null;
    }
}

public enum PrefabType { TypeA, TypeB, TypeC }

[System.Serializable]
public class PrefabData
{
    public string description;
    public float spawnChance;
}