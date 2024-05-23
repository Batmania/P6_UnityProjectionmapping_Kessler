using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isOpen = false;
    public Transform rotationPoint;
    public BoxCollider collisionBox;
    public float openingSpeed = 90F;

    private float maxYRotation = 90.0F;
    private float currentYRotationAlpha = 0F;

    void Start()
    {
        if (isOpen)
        {
            rotationPoint.localRotation = Quaternion.Euler(x:0,y:maxYRotation,z:0);
            currentYRotationAlpha = 1F;
        }
        else
        {
            rotationPoint.localRotation = Quaternion.Euler(x:0,y:0,z:0);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        float newYRotationAlpha = currentYRotationAlpha + ((Time.deltaTime * openingSpeed * (isOpen ? 1F : -1F)) / maxYRotation);
        currentYRotationAlpha = Mathf.Clamp(newYRotationAlpha, 0F, 1F);

        rotationPoint.localRotation = Quaternion.Euler(x: 0, y: /*lerpResult*/currentYRotationAlpha * maxYRotation, z: 0);
    }
}
