using UnityEngine;

public class Coin : MonoBehaviour
{   
    void OnTriggerEnter2D(Collider2D collision)
    {      
        Destroy(gameObject);       
    }   
}
