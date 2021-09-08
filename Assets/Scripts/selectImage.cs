using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectImage : MonoBehaviour
{
	public int imageId;

    private void OnMouseDown() {
        GetComponent<Animation>().Play("down");
    }

    private void OnMouseUp() {
        GetComponent<Animation>().Play("up");
    }
    
    private void OnMouseUpAsButton() {
    	PlayerPrefs.SetInt("selIImgId", imageId);
    	Application.LoadLevel("Filter");
    }
}
