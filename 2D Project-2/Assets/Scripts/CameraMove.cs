using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject thisObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            thisObject.transform.position = new Vector3(0, -57, -10);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            thisObject.transform.position = new Vector3(0, 0, -10);
        }
    }
}
