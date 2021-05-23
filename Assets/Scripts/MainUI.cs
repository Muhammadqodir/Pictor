using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public string action;
    public GameObject mainCamera;
    public GameObject cameraBox;

    private void OnMouseDown() {
        GetComponent<Animation>().Play("btn_down");
    }

    private void OnMouseUp() {
        GetComponent<Animation>().Play("btn_up");
    }
    
    private void OnMouseUpAsButton() {
        if(action == "camera"){
            cameraBox.GetComponent<Animation>().Play("open_box");
            mainCamera.GetComponent<PhoneCamera>().startStreaming = true;
        }else if(action == "gallery"){
            mainCamera.GetComponent<PhoneCamera>().initCamera();
        }
    }
}
