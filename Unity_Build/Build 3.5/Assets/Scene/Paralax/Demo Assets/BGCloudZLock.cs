using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCloudZLock : MonoBehaviour {

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 1.5f;
        transform.position = pos;
    }
}
