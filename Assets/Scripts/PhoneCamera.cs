using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneCamera : MonoBehaviour
{
    public bool startStreaming;
    private bool camAvailable;
    private WebCamTexture backCam;
    private Texture defaultBackground;

    public RawImage background;
    public AspectRatioFitter fit;

    public void initCamera(){
        defaultBackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;
        if(devices.Length == 0){
            camAvailable = false;
            Debug.Log("No cameras found");
            return;
        }

        for(int i = 0; i < devices.Length; i++){
            if(devices[i].isFrontFacing){
                backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        }

        if(backCam == null){
            Debug.Log("Unable to find  back camera");
            return;
        }

        backCam.Play();
        background.texture = backCam;

        camAvailable = true;
    }

    void Update()
    {
        if(!camAvailable && !startStreaming)
            return;

        float ratio = (float)backCam.width/(float)backCam.height;
        fit.aspectRatio = ratio;

        float scaleY = backCam.videoVerticallyMirrored ?    -1f: 1f;
        background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

        int orient = -backCam.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3(0, orient, 0);
    }

}
