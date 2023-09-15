using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject PlanetObject;
    public Vector3 Rotation;

    public void Update() {
        PlanetObject.transform.Rotate(Rotation * Time.deltaTime);
    }
}
