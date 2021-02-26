using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 3f;

    private Vector3 currentVelocity;

    void LateUpdate()
    {
        if(target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref currentVelocity, smoothSpeed * Time.deltaTime);
        }
    }
}
