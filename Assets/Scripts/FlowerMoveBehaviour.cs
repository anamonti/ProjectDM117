using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMoveBehaviour : MonoBehaviour
{
    void Start() {}

    void Update()
    {
        transform.Rotate(Vector3.down);
    }
}
