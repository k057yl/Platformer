using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator anim;
    public float speed;
    public float jumpForce = 15f;
    Vector2 moveVector;
    public bool onGround;
    public Transform groundChecker;
    public float checkRadius = 0.3f;
    public LayerMask Ground;
    public bool faceRight = true;
    public int credit;
    public Text creditText;
    public int lives = 3;
    public Text livesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            credit++;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            lives--;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void PlayerMove()
    {
        anim.SetFloat("Walk", Mathf.Abs(moveVector.x));
        moveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
    }
    void Jump()
    {
        if(Input.GetButtonDown("Jump") && onGround)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
    void CheckInGround()
    {
        anim.SetBool("onGround", onGround);
        onGround = Physics2D.OverlapCircle(groundChecker.position, checkRadius, Ground);
    }
    void Reflect()
    {
        if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
        {
            faceRight = !faceRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }
    void Death()
    {
        if(lives <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    void FixedUpdate()
    {
        PlayerMove();
    }
    void Update()
    {
        CheckInGround();
        Jump();
        Reflect();
        creditText.text = credit.ToString();
        livesText.text = lives.ToString();
        Death();
    }
}
