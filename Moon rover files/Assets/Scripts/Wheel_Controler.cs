using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel_Controlelr : MonoBehaviour
{
    public WheelCollider FR;
    public WheelCollider FL;
    public WheelCollider BR;
    public WheelCollider BL;
    public Transform FRT;
    public Transform FLT;
    public Transform BRT;
    public Transform BLT;

    public WheelCollider FRC;
    public WheelCollider FLC;
    public Transform FRTC;
    public Transform FLTC;

    public float acc = 600f;
    public float breakF = 400f;
    public float tAngle = 30f;

    private float currentAcc = 0f;
    private float currentBreakF = 0f;
    private float currentTAngle = 0f;

    private void FixedUpdate()
    {
        //acceleration
        currentAcc = acc * Input.GetAxis("Vertical");
        FR.motorTorque = currentAcc;
        FL.motorTorque = currentAcc;
        BR.motorTorque = currentAcc;
        BL.motorTorque = currentAcc;

        //breaking
        if (Input.GetKey(KeyCode.Space))
            currentBreakF = breakF;
        else
            currentBreakF = 0f;

        FR.brakeTorque = currentBreakF;
        FL.brakeTorque = currentBreakF;
        BR.brakeTorque = currentBreakF;
        BL.brakeTorque = currentBreakF;

        //turning
        currentTAngle = tAngle * Input.GetAxis("Horizontal");
        FR.steerAngle = currentTAngle;
        FL.steerAngle = currentTAngle;
        FRC.steerAngle = currentTAngle;
        FLC.steerAngle = currentTAngle;

        //Wheels spinning
        Vector3 pos;
        Quaternion rot;
        FL.GetWorldPose(out pos, out rot);
        FLT.position = pos;
        FLT.rotation = rot;
        FR.GetWorldPose(out pos, out rot);
        FRT.position = pos;
        FRT.rotation = rot;
        BL.GetWorldPose(out pos, out rot);
        BLT.position = pos;
        BLT.rotation = rot;
        BR.GetWorldPose(out pos, out rot);
        BRT.position = pos;
        BRT.rotation = rot;

        //Cover turn
        FLC.GetWorldPose(out pos, out rot);
        FLTC.rotation = rot;
        FRC.GetWorldPose(out pos, out rot);
        FRTC.rotation = rot;
    }
}
