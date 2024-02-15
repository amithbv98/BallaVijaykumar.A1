using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move the cube side to side
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        
        // Check tag
        if (other.CompareTag("Boundary"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z -0.3f);
            speed *= -1;
        }
        if (other.CompareTag("FrontWall")) { 
            Destroy(gameObject);
            EditorApplication.ExitPlaymode();
        }

    }
}