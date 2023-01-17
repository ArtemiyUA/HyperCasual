using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector3 initialRotation;


    private void Awake()
    {
        initialRotation = transform.eulerAngles;
    }
    private void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y,
            playerTransform.position.z);

        transform.eulerAngles = new Vector3(playerTransform.eulerAngles.x,
            playerTransform.eulerAngles.y + initialRotation.y, 0);
    }
}
