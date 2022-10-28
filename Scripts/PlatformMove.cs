using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] float speedPlatform;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.parent = transform;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
    }
    void Update()
    {
        if(transform.position.x > 9)
        {
            speedPlatform = -speedPlatform;
        }
        if (transform.position.x < 15)
        {
            speedPlatform = -speedPlatform;
        }
        Vector3 input = new Vector2(2f, 0f);
        transform.position = transform.position + input * Time.deltaTime * speedPlatform;
    }
}
