using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed = 5f;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.back * bulletSpeed;    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            Destroy(other.gameObject);
            Destroy(gameObject);
            EditorApplication.ExitPlaymode();
        }

        if (other.gameObject.CompareTag("Shields"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }



    }

}
