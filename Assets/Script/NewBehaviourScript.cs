using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using Ardunity;

public class NewBehaviourScript : MonoBehaviour {

    double value;
    public AnalogInput flexAnalogInput;

    void Start ()
    {
        
	}

    // Update is called once per frame
    
    void Update()
    {
        value = (double)flexAnalogInput.Value * 1000;
        value = (int)value;
        Debug.Log(value);
    }
    
}
