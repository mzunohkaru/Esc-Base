using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  �}�E�X���b�O�ŃA�C�e������]  */
public class ItemRotation : MonoBehaviour
{
    [SerializeField] Transform zoomObjParent;

    [SerializeField] Transform canvas;

    float speed = 6;

    private void Update()
    {
        //�N���b�N���̂�
        if(Input.GetMouseButton(0))
        {
            //��]
            float dy = -Input.GetAxis("Mouse X") * speed;
            float dx = Input.GetAxis("Mouse Y") * speed;
            //zoomObjParent.RotateAround(transform.position, canvas.transform.rotation * Vector3.up, dy);
            //zoomObjParent.RotateAround(transform.position, canvas.transform.rotation * Vector3.right, dx);

            //RotateAround(���S,��,��]�p�x)
            transform.RotateAround(
                transform.position,
                //�J�����̈ړ��������␳
                Quaternion.Euler(zoomObjParent.rotation.eulerAngles) * Vector3.up,
                dx);
            transform.RotateAround(
                transform.position,
                Quaternion.Euler(zoomObjParent.rotation.eulerAngles) * Vector3.right,
                dy);
        }
        
    }
}
