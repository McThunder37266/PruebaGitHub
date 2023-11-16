using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(30, 50, 70) * Time.deltaTime);
    }
}
