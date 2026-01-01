using UnityEngine;

// Simple spawner to place models in the scene for quick prototyping
public class ModelSpawner : MonoBehaviour
{
    [Tooltip("Prefab models to spawn (set in inspector)")]
    public GameObject[] models;

    [Tooltip("Default spawn positions relative to this GameObject")]
    public Vector3[] spawnPositions;

    private GameObject[] spawned;

    void Start()
    {
        SpawnAll();
    }

    public void SpawnAll()
    {
        if (models == null || models.Length == 0) return;

        spawned = new GameObject[models.Length];
        for (int i = 0; i < models.Length; i++)
        {
            Vector3 pos = (spawnPositions != null && i < spawnPositions.Length) ? spawnPositions[i] : new Vector3(i * 1.5f, 0, 0);
            spawned[i] = Instantiate(models[i], transform.position + pos, Quaternion.identity, transform);
            spawned[i].name = models[i].name + "_instance";
        }
    }

    public void Clear()
    {
        if (spawned == null) return;
        for (int i = 0; i < spawned.Length; i++)
        {
            if (spawned[i] != null) Destroy(spawned[i]);
        }
    }

    public void SpawnByIndex(int index)
    {
        if (index < 0 || index >= models.Length) return;
        Vector3 pos = (spawnPositions != null && index < spawnPositions.Length) ? spawnPositions[index] : Vector3.zero;
        Instantiate(models[index], transform.position + pos, Quaternion.identity, transform);
    }
}