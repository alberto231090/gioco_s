using UnityEngine;

// Very small prototype controller to simulate basic babysitter actions
public class BabysitterController : MonoBehaviour
{
    public Transform holdPoint; // where picked-up child attaches
    private GameObject heldObject;

    void Update()
    {
        // Quick prototyping controls (keyboard):
        // P = pick nearest child, R = release
        if (Input.GetKeyDown(KeyCode.P)) PickNearestChild();
        if (Input.GetKeyDown(KeyCode.R)) ReleaseHeld();
    }

    void PickNearestChild()
    {
        if (heldObject != null) return;
        float best = 999f; GameObject bestObj = null;
        foreach (var child in GameObject.FindGameObjectsWithTag("Child"))
        {
            float d = Vector3.Distance(transform.position, child.transform.position);
            if (d < best) { best = d; bestObj = child; }
        }
        if (bestObj != null && best < 3f)
        {
            heldObject = bestObj;
            heldObject.transform.SetParent(holdPoint);
            heldObject.transform.localPosition = Vector3.zero;
            if (heldObject.TryGetComponent<Rigidbody>(out var rb)) rb.isKinematic = true;
        }
    }

    void ReleaseHeld()
    {
        if (heldObject == null) return;
        heldObject.transform.SetParent(null);
        if (heldObject.TryGetComponent<Rigidbody>(out var rb)) rb.isKinematic = false;
        heldObject = null;
    }

    // Hook: call to console or UI to trigger "console" action
    public void ConsoleAction()
    {
        Debug.Log("Consoling action triggered (prototype)");
        // TODO: play animation / audio
    }
}