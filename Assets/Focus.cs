using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Vuforia;

public class NewBehaviourScript : MonoBehaviour
{
    void Start(){
        OnSingleTapped();
    }// Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
        OnSingleTapped();
    }
    private void OnSingleTapped(){
        TriggerAutoFocus();
    }
    public void TriggerAutoFocus(){
        StartCoroutine(TriggerAutoFocusAndEnableContinuousFocusIfSet());
    }
    private IEnumerator TriggerAutoFocusAndEnableContinuousFocusIfSet(){
        yield return new WaitForSeconds(0.5f);
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}
