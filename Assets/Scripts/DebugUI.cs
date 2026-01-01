using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class DebugUI : MonoBehaviour
{
    public Text infoText;
    public ModelSpawner spawner;

    void Update()
    {
        if (infoText == null || spawner == null) return;
        infoText.text = $"Models: { (spawner.models!=null? spawner.models.Length.ToString() : "0") } - Press P to pick, R to release";
    }
}