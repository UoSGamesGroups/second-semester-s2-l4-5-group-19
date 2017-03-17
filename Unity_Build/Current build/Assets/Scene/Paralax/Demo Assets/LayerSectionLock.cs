using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSectionLock : MonoBehaviour {

	void Update ()
    {
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
    }
}
