using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;

    [SerializeField] GameObject backButton;
    [SerializeField] GameObject leftButton;
    [SerializeField] GameObject rightButton;

    [SerializeField] Transform[] cameraPositions;
    int currentIndex;
    Camera zoomCamera = null;
    Camera mainCamera;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        mainCamera = Camera.main;
        currentIndex = 0;
        SetCameraPosition(currentIndex);
        leftButton.SetActive(true);
        rightButton.SetActive(true);
        backButton.SetActive(false);
    }

    public void TurnRight()
    {
        currentIndex++;
        if (currentIndex >= cameraPositions.Length)
        {
            currentIndex = 0;
        }
        SetCameraPosition(currentIndex);
    }

    public void TurnLeft()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = cameraPositions.Length - 1;
        }
        SetCameraPosition(currentIndex);
    }


    public void OnBack()
    {
        backButton.SetActive(false);
        leftButton.SetActive(true);
        rightButton.SetActive(true);

        //ズームカメラ非表示
        this.zoomCamera.gameObject.SetActive(false);
        //メインカメラ復活
        mainCamera.gameObject.SetActive(true);

        ZoomPanel.instance.SetRenderCamera(mainCamera);
    }

    void SetCameraPosition(int index)
    {
        mainCamera.transform.position = cameraPositions[index].position;
        mainCamera.transform.rotation = cameraPositions[index].rotation;
    }

    public void SetZoomCamera(Camera zoomCamera)
    {
        this.zoomCamera = zoomCamera;
        backButton.SetActive(true);
        leftButton.SetActive(false);
        rightButton.SetActive(false);
        mainCamera.gameObject.SetActive(false);

        ZoomPanel.instance.SetRenderCamera(zoomCamera);
    }
}
