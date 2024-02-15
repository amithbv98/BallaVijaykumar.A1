using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{
    public float bulletSpeed;

    private Rigidbody rb;


    private void Awake()
    {
        Destroy(gameObject, 3f);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        rb.velocity = transform.forward * bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Enemy")
        {
            Destroy(other.gameObject);  
        }
    }

}
