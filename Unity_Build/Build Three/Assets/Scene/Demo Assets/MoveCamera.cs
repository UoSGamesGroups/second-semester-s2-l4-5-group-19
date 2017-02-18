using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float speed = 5f;

	public void Update ()
    {
        var movementx = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += movementx * speed * Time.deltaTime;
    }
}
