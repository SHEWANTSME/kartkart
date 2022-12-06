using UnityEngine;

public class RotateTank : MonoBehaviour
{
    [Tooltip("Applies a rotation of eulerAngles.z degrees around the z-axis, eulerAngles.x degrees around the x-axis, and eulerAngles.y degrees around the y-axis (in that order).")]

    public Vector3 TANK;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(TANK);
    }
}
