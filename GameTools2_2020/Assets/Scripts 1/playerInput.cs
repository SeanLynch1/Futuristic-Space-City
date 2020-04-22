using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{

    
    public event eventManager.InputEventFloat ForwardEvent;
    public event eventManager.InputEventFloat YawEvent;
    public event eventManager.InputEventFloat PitchEvent;
    public event eventManager.InputEventFloat RollEvent;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetKeyboardInput();
    }

    void GetKeyboardInput()
    {
        if (ForwardEvent != null)
        {
            if (Input.GetAxis("Throtle") != 0) ForwardEvent(Input.GetAxis("Throtle"));
        }

        if (PitchEvent != null)
        {
            if (Input.GetAxis("Vertical") != 0) PitchEvent(Input.GetAxis("Vertical"));

        }
        if (YawEvent != null)
        {
            if (Input.GetAxis("Horizontal") != 0) YawEvent(Input.GetAxis("Horizontal"));
        }

        if (RollEvent != null)
        {
            if (Input.GetAxis("Roll") != 0) RollEvent(Input.GetAxis("Roll"));
        }
        
    }
}
