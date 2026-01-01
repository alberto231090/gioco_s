using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class DebugUITests
{
    [Test]
    public void Update_ShowsModelCount()
    {
        var canvasGO = new GameObject("Canvas");
        var canvas = canvasGO.AddComponent<Canvas>();
        var textGO = new GameObject("DebugText");
        textGO.transform.SetParent(canvasGO.transform, false);
        var text = textGO.AddComponent<Text>();
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");

        var spawnerGO = new GameObject("Spawner");
        var spawner = spawnerGO.AddComponent<ModelSpawner>();
        spawner.models = new GameObject[] { new GameObject("Model") };

        var debugGO = new GameObject("DebugUI");
        var debug = debugGO.AddComponent<DebugUI>();
        debug.infoText = text;
        debug.spawner = spawner;

        debug.Update();

        Assert.IsTrue(text.text.Contains("Models: 1"));
        Assert.IsTrue(text.text.Contains("Press P"));
        
        Object.DestroyImmediate(debugGO);
        Object.DestroyImmediate(spawnerGO);
        Object.DestroyImmediate(canvasGO);
    }
}