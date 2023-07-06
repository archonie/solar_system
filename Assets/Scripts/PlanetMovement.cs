using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{
    public float rotateRate;
    // Update is called once per frame
    void Update()
    {
      transform.Rotate(0,rotateRate,0, Space.World);  
    }
}
