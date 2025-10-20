using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 90.0f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local Y axis
        // Time.deltaTime makes the rotation smooth and frame-rate independent
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }
}