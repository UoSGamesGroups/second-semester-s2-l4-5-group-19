﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBGCloudZLock : MonoBehaviour {

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 0.5f;
        transform.position = pos;
    }
}
