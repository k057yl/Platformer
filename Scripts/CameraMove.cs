using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] internal Transform player;
    [SerializeField] Vector3 offset;
    void Update()
    {
        transform.position = player.position + offset;
    }
}
