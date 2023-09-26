using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerX : MonoBehaviour
{
    private float rotationSpeed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate propeller at rotationSpeed
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
