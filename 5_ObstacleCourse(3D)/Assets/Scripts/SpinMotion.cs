using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMotion : MonoBehaviour
{
    // float spinValue = 1f;
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
