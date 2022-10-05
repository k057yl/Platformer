using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public AudioSource hit;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject newBillet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            newBillet.GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed;
            hit.Play();
        }
    }
    
}
