using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    internal Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
}
