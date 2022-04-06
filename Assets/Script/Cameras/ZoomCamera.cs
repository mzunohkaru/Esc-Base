using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    [SerializeField] Camera zoomCamera;
    

    // ズーム用のカメラと切り替える
    public void OnClickZoom()
    {
        zoomCamera.gameObject.SetActive(true);
        CameraManager.instance.SetZoomCamera(zoomCamera);
    }
}
