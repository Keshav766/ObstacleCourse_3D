using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeCheck = 5f;
    Rigidbody fallingbody;
    MeshRenderer fallingRenderer;
    // Start is called before the first frame update
    void Start()
    {
        fallingRenderer = GetComponent<MeshRenderer>();
        fallingbody = GetComponent<Rigidbody>();
            fallingRenderer.enabled = false;
            fallingbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeCheck)
        {
            // Debug.Log("4 seconds are elapsed");
            fallingRenderer.enabled = true;
            fallingbody.useGravity = true;
        }
    }
}
