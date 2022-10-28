using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] internal Transform gChecker;
    [SerializeField] internal bool onGround;
    internal float checkRadius = 0.2f;
    [SerializeField] internal LayerMask Ground;
}
