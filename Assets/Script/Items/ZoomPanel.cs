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

    //メインカメラ以外でもZoomPanelを出す
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
        選択中のアイテムを表示 
        表示 = データベースから生成
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

    //アイテム表示
    public void ShowItem(Item item)
    {
        if (zoomItem != null)
        {
            Destroy(zoomItem);
        }
        //生成
        zoomItem = ItemDatabase.instance.CreateZoomItem(item.type);
        //親を決め、位置も反映
        zoomItem.transform.SetParent(zoomObjParent, false);

        ItemBox.instance.SetShowSlot();
    }

    // X Button
    public void HideZoomPanel()
    {
        zoomPanel.SetActive(false);
    }
}
