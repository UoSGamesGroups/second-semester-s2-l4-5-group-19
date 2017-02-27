using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarZLock : MonoBehaviour {

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 1;
        transform.position = pos;
    }
}