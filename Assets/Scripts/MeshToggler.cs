using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject TurbineObject;
    public bool IsActive = true;

    public void Toggle() {
        if (IsActive)
        {
            TurbineObject.SetActive(false);
            IsActive = false;
        }
        else {
            TurbineObject.SetActive(true);
            IsActive = true;
        }
    }
}
