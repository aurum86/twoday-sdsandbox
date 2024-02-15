using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOverTime : MonoBehaviour
{
    public float rotationSpeed = 15f;
    public bool rotationClockwise = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int direction = (this.rotationClockwise) ? 1 : -1;

        transform.Rotate(Vector3.forward, direction * rotationSpeed * Time.deltaTime);
    }
}
