using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaRosa : MonoBehaviour
{
    public SliderJoint2D slider;
    public JointMotor2D temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = slider.motor;
    }

    // Update is called once per frame
    void Update()
    {
       if(slider.limitState)
    }
}
