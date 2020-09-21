using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{   

    public GameObject plane;

    public void Slider_Changed(float newValue){
        Vector3 pos = plane.transform.position;
        pos.y = newValue;
        plane.transform.position = pos;
    }

}
