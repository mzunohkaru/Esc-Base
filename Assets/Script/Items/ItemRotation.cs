using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  マウスラッグでアイテムを回転  */
public class ItemRotation : MonoBehaviour
{
    [SerializeField] Transform zoomObjParent;

    [SerializeField] Transform canvas;

    float speed = 6;

    private void Update()
    {
        //クリック中のみ
        if(Input.GetMouseButton(0))
        {
            //回転
            float dy = -Input.GetAxis("Mouse X") * speed;
            float dx = Input.GetAxis("Mouse Y") * speed;
            //zoomObjParent.RotateAround(transform.position, canvas.transform.rotation * Vector3.up, dy);
            //zoomObjParent.RotateAround(transform.position, canvas.transform.rotation * Vector3.right, dx);

            //RotateAround(中心,軸,回転角度)
            transform.RotateAround(
                transform.position,
                //カメラの移動分だけ補正
                Quaternion.Euler(zoomObjParent.rotation.eulerAngles) * Vector3.up,
                dx);
            transform.RotateAround(
                transform.position,
                Quaternion.Euler(zoomObjParent.rotation.eulerAngles) * Vector3.right,
                dy);
        }
        
    }
}
