
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int lives = 3;
    public float speed = 2f;
    public float distance;
    bool moveX = true;
    public Transform platformCheck;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(platformCheck.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if(moveX == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveX = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveX = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            lives--;
        }
        if (lives <= 0)
        {
            Destroy(gameObject);
        }
    }
}
