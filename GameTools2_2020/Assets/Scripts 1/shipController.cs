using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{

    public playerInput playerInput;
    public float forwardThrustPower = 100f;
    public float yawSpeed = 10f;
    public float pitchSpeed = 10f;
    public float rollSpeed = 10f;
    public float invertModifier = -1;
    Rigidbody myRigidbody;    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        playerInput.ForwardEvent += ForwardThrust;
        playerInput.YawEvent += YawMovement;
        playerInput.PitchEvent += PitchMovement;
        playerInput.RollEvent += RollMovement;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ForwardThrust(float thrust)
    {
        myRigidbody.AddForce(gameObject.transform.forward * thrust * forwardThrustPower * Time.deltaTime);
    }
    public void YawMovement(float Yaw)
    {
        myRigidbody.AddTorque(gameObject.transform.up * Yaw * yawSpeed * Time.deltaTime);
    }
    public void PitchMovement(float pitch)
    {
        myRigidbody.AddTorque(gameObject.transform.right * pitch * invertModifier * pitchSpeed * Time.deltaTime);
    }
    public void RollMovement(float roll)
    {
        myRigidbody.AddTorque(gameObject.transform.forward * roll * rollSpeed * Time.deltaTime);
    }

}
