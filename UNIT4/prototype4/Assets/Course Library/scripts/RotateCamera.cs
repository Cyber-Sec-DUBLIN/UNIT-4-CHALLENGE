using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  public float rotationSpeed = 25;
void Update()
{
float horizontalInput = Input.GetAxis("Horizontal");
transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
}
}