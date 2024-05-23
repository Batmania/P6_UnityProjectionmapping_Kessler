using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public bool doorIsOpen = false;
    public Transform door; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpen)
        {
            door.rotation = Quaternion.Euler(x:0,y:90,z:0);
        }
        else
        {
            door.rotation = Quaternion.Euler(x:0,y:0,z:0);
        }
    }
}
