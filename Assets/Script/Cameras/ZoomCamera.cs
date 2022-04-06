using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    [SerializeField] Camera zoomCamera;
    

    // �Y�[���p�̃J�����Ɛ؂�ւ���
    public void OnClickZoom()
    {
        zoomCamera.gameObject.SetActive(true);
        CameraManager.instance.SetZoomCamera(zoomCamera);
    }
}
