using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FGCloudZLock : MonoBehaviour {

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 50;
        transform.position = pos;
    }
}
