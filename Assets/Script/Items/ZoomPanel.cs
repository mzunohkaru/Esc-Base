using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject zoomPanel;
    Canvas canvas;
    [SerializeField] Transform zoomObjParent;
    GameObject zoomItem;

    public static ZoomPanel instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        canvas = GetComponent<Canvas>();
        HideZoomPanel();
    }

    //���C���J�����ȊO�ł�ZoomPanel���o��
    public void SetRenderCamera(Camera camera)
    {
        canvas.worldCamera = camera;
    }

    public void OnClickZoom()
    {
        Item selectItem = ItemBox.instance.GetSelectItem();

        if (selectItem == null)
        {
            return;
        }

        zoomPanel.SetActive(true);
        ShowClickItem();
    }

    /*  
        �I�𒆂̃A�C�e����\�� 
        �\�� = �f�[�^�x�[�X���琶��
     */
    public void ShowClickItem()
    {
        if (zoomItem != null)
        {
            Destroy(zoomItem);
        }
        Item selectItem = ItemBox.instance.GetSelectItem();
        ShowItem(selectItem);
    }

    //�A�C�e���\��
    public void ShowItem(Item item)
    {
        if (zoomItem != null)
        {
            Destroy(zoomItem);
        }
        //����
        zoomItem = ItemDatabase.instance.CreateZoomItem(item.type);
        //�e�����߁A�ʒu�����f
        zoomItem.transform.SetParent(zoomObjParent, false);

        ItemBox.instance.SetShowSlot();
    }

    // X Button
    public void HideZoomPanel()
    {
        zoomPanel.SetActive(false);
    }
}
