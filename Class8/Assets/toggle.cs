using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class toggle : MonoBehaviour
{
    public Transform t;
    public bool flag;
    public Vector3 previousT;
    public Vector3 previousR;
    // Start is called before the first frame update
    void Start()
    {
        previousT = transform.position;
        previousR = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("c"))
        {
            if (flag)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
        }
        try { 
            if (flag) {

                    transform.position = t.position + new Vector3(0, 0, 1);
                    transform.localEulerAngles = new Vector3(0, 0, 0);

            }
            else {
                transform.position = previousT;
                transform.localEulerAngles = previousR;
            }
        }
        catch (MissingReferenceException e) { 
            EditorApplication.ExitPlaymode();
        }

    }
}
