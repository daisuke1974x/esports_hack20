using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DualshockInputController : MonoBehaviour, IVirtualController
{
    public PlayerStatics.Player player = PlayerStatics.Player.one;

    string inputNameVertical = "LeftAnalogStick_Y_";
    string inputNameHorizontal = "LeftAnalogStick_X_";
    string inputNameHorizontalCamera = "RightAnalogStick_X_";
    string inputNameVerticalCamera = "RightAnalogStick_Y_";
    string inputNameJump = "Jump_";
    string inputNameFire1 = "Fire_";    
    string inputNameL1 = "L1_";

    // Start is called before the first frame update
    void Start()
    {
        GetKeyName();
    }

    public float GetMoveVertical()
    {
        float _input = Input.GetAxisRaw(inputNameVertical);
        if ( Mathf.Abs(_input) < 0.2F)
        {
            return 0F;
        }
        return _input;
    }
    public float GetMoveHorizontal()
    {
        float _input = Input.GetAxisRaw(inputNameHorizontal);
        if (Mathf.Abs(_input) < 0.2F)
        {
            return 0F;
        }
        return _input;
    }
    public float GetCameraVertical()
    {
        float _input = Input.GetAxis(inputNameVerticalCamera);
        if (Mathf.Abs(_input) < 0.2F)
        {
            return 0F;
        }
        return _input;
    }
    public float GetCameraHorizontal()
    {
        float _input = Input.GetAxis(inputNameHorizontalCamera);
        if (Mathf.Abs(_input) < 0.2F)
        {
            return 0F;
        }
        return Input.GetAxis(inputNameHorizontalCamera);
    }
    public bool GetCameraModeButton()
    {
        return Input.GetButton(inputNameL1);
    }
    public bool GetJumpButton()
    {
        return Input.GetButtonDown(inputNameJump);
    }
    public bool GetFireButton()
    {
        return Input.GetButtonDown(inputNameFire1);
    }
    
    void GetKeyName()
    {
        string _s = Convert.ToString( (int) player);
        inputNameL1 += _s;
        inputNameHorizontalCamera += _s;
        inputNameVerticalCamera += _s;
        inputNameFire1 += _s;
        inputNameVertical += _s;
        inputNameHorizontal += _s;
        inputNameJump += _s;
    }
}
