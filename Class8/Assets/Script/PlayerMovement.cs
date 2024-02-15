using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Get horizontal input (left or right arrow keys, A or D keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);

        // Move the cube based on the input
        transform.Translate(movement * speed * Time.deltaTime);
    }
}