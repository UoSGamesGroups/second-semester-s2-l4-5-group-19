using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxZLock : MonoBehaviour
{
    void Update()
    {
        if (gameObject.tag == "FG Cloud")
        {
            Vector3 pos = transform.position;
            pos.z = 50;
            transform.position = pos;
        }

        if (gameObject.tag == "Moon")
        {
            Vector3 pos = transform.position;
            pos.z = 55;
            transform.position = pos;
        }

        if (gameObject.tag == "MFG Cloud")
        {
            Vector3 pos = transform.position;
            pos.z = 60;
            transform.position = pos;
        }

        if (gameObject.tag == "Sun")
        {
            Vector3 pos = transform.position;
            pos.z = 65;
            transform.position = pos;
        }

        if (gameObject.tag == "MBG Cloud")
        {
            Vector3 pos = transform.position;
            pos.z = 70;
            transform.position = pos;
        }

        if (gameObject.tag == "Star")
        {
            Vector3 pos = transform.position;
            pos.z = 75;
            transform.position = pos;
        }

        if (gameObject.tag == "BG Cloud")
        {
            Vector3 pos = transform.position;
            pos.z = 80;
            transform.position = pos;
        }
    }
}
