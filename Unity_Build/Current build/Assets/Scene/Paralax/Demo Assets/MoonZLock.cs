using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonZLock : MonoBehaviour {

	void Update ()
    {
        Vector3 pos = transform.position;
        pos.z = 55;
        transform.position = pos;
    }
}
