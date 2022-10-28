using UnityEngine;
namespace Platformer.Data
{
    public class Player : MonoBehaviour
    {
        [SerializeField] int healt;
        [SerializeField] int lives;
        [SerializeField] internal float speed;
        [SerializeField] internal float jumpForce;
        [SerializeField] internal bool faceRight = true;
        internal Rigidbody2D rb;
        internal Vector2 move;
        
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }
}
