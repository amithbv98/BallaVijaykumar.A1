using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perspective : MonoBehaviour
{
    public Transform t;
    public bool toggle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 previous = transform.position;
        if (Input.GetKeyUp("c"))
        {
            if(toggle)
            {
                transform.Translate(t.position);
                toggle = false;
            }      
            else
            {
                transform.Translate(previous);
                toggle = true;
            }
        }

    }
}
