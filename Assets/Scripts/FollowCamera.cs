using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float cameraHeight = 10;

    
    void Update()
    {
        transform.position = target.position - transform.forward * cameraHeight;
    }
}
