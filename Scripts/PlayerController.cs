using UnityEngine;
using Platformer.Data;
public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    Player player;
    GroundChecker groundChecker;
    PlayerAnimator playerAnimator;
    
    void Start()
    {
        player = FindObjectOfType<Player>();
        groundChecker = FindObjectOfType<GroundChecker>();
        playerAnimator = FindObjectOfType<PlayerAnimator>();
    }
    void Run()
    {
        playerAnimator.animator.SetFloat("Run", Mathf.Abs(player.move.x));
        player.move.x = Input.GetAxisRaw("Horizontal");
        player.rb.velocity = new Vector2(player.move.x * player.speed, player.rb.velocity.y);
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && groundChecker.onGround)
        {
            player.rb.AddForce(Vector2.up * player.jumpForce);
        }
    }
    void CheckInGround()
    {
        playerAnimator.animator.SetBool("OnGround", groundChecker.onGround);
        groundChecker.onGround = Physics2D.OverlapCircle(groundChecker.gChecker.position, groundChecker.checkRadius, groundChecker.Ground);
    }
    void Reflect()
    {
        if ((player.move.x > 0 && !player.faceRight) || (player.move.x < 0 && player.faceRight))
        {
            player.faceRight = !player.faceRight;
            player.transform.Rotate(0f, 180f, 0f);
        }
}
    void FixedUpdate()
    {
        Run();
    }
    private void Update()
    {
        Jump();
        CheckInGround();
        Reflect();
    }
}
