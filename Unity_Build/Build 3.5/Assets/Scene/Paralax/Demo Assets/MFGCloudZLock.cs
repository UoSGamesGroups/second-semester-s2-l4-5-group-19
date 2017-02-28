using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MFGCloudZLock : MonoBehaviour {

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 60;
        transform.position = pos;
    }
}
