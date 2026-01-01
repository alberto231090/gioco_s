using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections;
using System.Reflection;

public class BabysitterControllerTests
{
    [UnityTest]
    public IEnumerator PickAndRelease_WorkAndToggleRigidbody()
    {
        var babysitterGO = new GameObject("Babysitter");
        var bs = babysitterGO.AddComponent<BabysitterController>();
        var hold = new GameObject("HoldPoint");
        hold.transform.SetParent(babysitterGO.transform, false);
        hold.transform.localPosition = new Vector3(0, 1, 0);
        bs.holdPoint = hold.transform;

        var child = GameObject.CreatePrimitive(PrimitiveType.Cube);
        child.tag = "Child";
        child.transform.position = new Vector3(1, 0, 0);
        var rb = child.AddComponent<Rigidbody>();

        // Call private method PickNearestChild
        var pick = typeof(BabysitterController).GetMethod("PickNearestChild", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.IsNotNull(pick, "PickNearestChild method not found (reflection)");
        pick.Invoke(bs, null);

        yield return null; // wait a frame

        Assert.AreEqual(hold.transform, child.transform.parent);
        Assert.IsTrue(rb.isKinematic);

        // Release
        var release = typeof(BabysitterController).GetMethod("ReleaseHeld", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.IsNotNull(release, "ReleaseHeld method not found (reflection)");
        release.Invoke(bs, null);

        yield return null;

        Assert.IsNull(child.transform.parent);
        Assert.IsFalse(rb.isKinematic);

        Object.Destroy(child);
        Object.Destroy(hold);
        Object.Destroy(babysitterGO);
    }
}