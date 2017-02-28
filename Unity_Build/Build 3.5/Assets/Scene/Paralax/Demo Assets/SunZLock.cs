using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunZLock : MonoBehaviour
{

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 65;
        transform.position = pos;
    }
}