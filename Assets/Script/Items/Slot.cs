using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] GameObject backPanel;

    Item item = null;

    private void Start()
    {
        backPanel.SetActive(false);
    }

    //Itemを受け取れば、画像を表示
    public void Set(Item item)
    {
        this.item = item;
        image.sprite = item.sprite;
    }

    public void RemoveItem()
    {
        item = null;
        image.sprite = null;
        HideBackPanel();
    }

    //アイテム取得
    public Item GetItem()
    {
        return item;
    }

    public bool IsEmpty()
    {
        if(item == null)
        {
            return true;
        }
        return false;
    }

    public void OnSelected()
    {
        backPanel.SetActive(true);
    }

    //選択中Panel
    public void HideBackPanel()
    {
        backPanel.SetActive(false);
    }
}
