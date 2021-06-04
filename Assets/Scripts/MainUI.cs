using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public string action;
    public GameObject mainCamera;
    public GameObject cameraBox;
    public GameObject white;

    private void OnMouseDown() {
        GetComponent<Animation>().Play("btn_down");
    }

    private void OnMouseUp() {
        GetComponent<Animation>().Play("btn_up");
    }
    
    private void OnMouseUpAsButton() {
        if(action == "camera"){
            mainCamera.GetComponent<PhoneCamera>().initCamera();
            cameraBox.GetComponent<Animation>().Play("open_box");
            mainCamera.GetComponent<PhoneCamera>().startStreaming = true;
            white.GetComponent<Animation>().Play("fade_in");
        }else if(action == "gallery"){
            Application.LoadLevel("Filter");
        }
    }
}
