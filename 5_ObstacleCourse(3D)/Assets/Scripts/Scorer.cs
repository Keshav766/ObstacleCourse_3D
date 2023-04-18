using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpCount = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            bumpCount++;
            Debug.Log("Till Now U have Bumped : " + bumpCount);
        }
    }
}
