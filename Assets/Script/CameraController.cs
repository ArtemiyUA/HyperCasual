using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Vector3 initialPossition;
    [SerializeField] Vector3 maxPossition;
    [SerializeField] [Range(0, 1)] float progress;

    private void Awake()
    {
        transform.localPosition = initialPossition;
    }
    void LateUpdate()
    {
        transform.localPosition = Vector3.Lerp(initialPossition, maxPossition, progress);
    }
}
