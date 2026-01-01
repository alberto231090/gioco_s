using NUnit.Framework;
using UnityEngine;
using UnityEditor;

public class ModelSpawnerTests
{
    [Test]
    public void SpawnAll_CreatesInstancesAndClear_RemovesThem()
    {
        var go = new GameObject("Spawner");
        var spawner = go.AddComponent<ModelSpawner>();

        var modelA = new GameObject("ModelA");
        var modelB = new GameObject("ModelB");

        spawner.models = new GameObject[] { modelA, modelB };
        spawner.spawnPositions = new Vector3[] { new Vector3(0, 0, 0), new Vector3(1.5f, 0, 0) };

        spawner.SpawnAll();

        Assert.AreEqual(2, go.transform.childCount);
        Assert.IsNotNull(go.transform.Find("ModelA_instance"));
        Assert.IsNotNull(go.transform.Find("ModelB_instance"));

        spawner.Clear();

        Assert.AreEqual(0, go.transform.childCount);

        Object.DestroyImmediate(modelA);
        Object.DestroyImmediate(modelB);
        Object.DestroyImmediate(go);
    }
}