using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterUI : MonoBehaviour
{
    public string action;

    private void OnMouseUpAsButton() {
        if(action == "back"){
            Application.LoadLevel("Main");
        }
    }
}
