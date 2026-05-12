using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 6, -8);
    public float pitch = 10f;
    public float yaw = 0f;

    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
        transform.Rotate(pitch,yaw, 0);
    }
}
