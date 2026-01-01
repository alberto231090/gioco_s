#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.IO;

// Utility editor to create a prototype scene automatically
public class ExampleSceneBuilder
{
    [MenuItem("Tools/Babysitter/Setup Example Scene")]
    public static void SetupExampleScene()
    {
        // Create new scene
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        scene.name = "PrototypeScene";

        // Add directional light
        var lightGO = new GameObject("Directional Light");
        var light = lightGO.AddComponent<Light>();
        light.type = LightType.Directional;
        light.intensity = 1f;

        // Add camera
        var camGO = new GameObject("Main Camera");
        var cam = camGO.AddComponent<Camera>();
        cam.tag = "MainCamera";
        cam.transform.position = new Vector3(0, 1.6f, -3f);
        cam.transform.LookAt(Vector3.zero);

        // Add Canvas & Text (for DebugUI)
        var canvasGO = new GameObject("Canvas");
        var canvas = canvasGO.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvasGO.AddComponent<UnityEngine.UI.CanvasScaler>();
        canvasGO.AddComponent<UnityEngine.UI.GraphicRaycaster>();

        var textGO = new GameObject("DebugText");
        textGO.transform.SetParent(canvasGO.transform, false);
        var text = textGO.AddComponent<UnityEngine.UI.Text>();
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        text.text = "Loading...";
        text.alignment = TextAnchor.UpperLeft;
        var rect = text.GetComponent<RectTransform>();
        rect.anchorMin = new Vector2(0, 1);
        rect.anchorMax = new Vector2(0, 1);
        rect.pivot = new Vector2(0, 1);
        rect.anchoredPosition = new Vector2(10, -10);
        rect.sizeDelta = new Vector2(400, 100);

        // Create SceneManager with ModelSpawner
        var managerGO = new GameObject("SceneManager");
        var spawner = managerGO.AddComponent<ModelSpawner>();

        // Ensure Prefabs folder exists
        if (!AssetDatabase.IsValidFolder("Assets/Prefabs"))
        {
            AssetDatabase.CreateFolder("Assets", "Prefabs");
        }

        // Find models in Assets/Models (glb, gltf, fbx)
        string[] guids = AssetDatabase.FindAssets("t:GameObject", new[] {"Assets/Models"});
        var prefabs = new System.Collections.Generic.List<GameObject>();
        var spawnPositions = new System.Collections.Generic.List<Vector3>();

        foreach (var guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            var go = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (go == null) continue;

            // Create prefab in Assets/Prefabs if not exists
            string prefabPath = "Assets/Prefabs/" + go.name + ".prefab";
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
            if (prefab == null)
            {
                prefab = PrefabUtility.SaveAsPrefabAsset(go, prefabPath);
            }

            if (prefab != null)
            {
                prefabs.Add(prefab);
                spawnPositions.Add(new Vector3(prefabs.Count * 1.5f - 3f, 0f, 0f));
            }
        }

        // Assign to spawner
        spawner.models = prefabs.ToArray();
        spawner.spawnPositions = spawnPositions.ToArray();

        // Create Babysitter object
        var babysitterGO = new GameObject("Babysitter");
        babysitterGO.transform.position = new Vector3(0, 0, -1f);
        var bs = babysitterGO.AddComponent<BabysitterController>();
        var hold = new GameObject("HoldPoint");
        hold.transform.SetParent(babysitterGO.transform, false);
        hold.transform.localPosition = new Vector3(0, 1.0f, 0);
        bs.holdPoint = hold.transform;

        // Attach DebugUI
        var debugUI = managerGO.AddComponent<DebugUI>();
        debugUI.infoText = text;
        debugUI.spawner = spawner;

        // Save scene
        string scenesDir = "Assets/Scenes";
        if (!AssetDatabase.IsValidFolder(scenesDir)) AssetDatabase.CreateFolder("Assets", "Scenes");
        string scenePath = scenesDir + "/PrototypeScene.unity";
        EditorSceneManager.SaveScene(scene, scenePath);

        EditorUtility.DisplayDialog("Setup Complete", "Example scene created: " + scenePath, "OK");
    }
}
#endif