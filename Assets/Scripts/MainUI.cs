using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public string action;
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
        }
    }
}
