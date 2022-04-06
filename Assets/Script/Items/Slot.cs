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

    //Item���󂯎��΁A�摜��\��
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

    //�A�C�e���擾
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

    //�I��Panel
    public void HideBackPanel()
    {
        backPanel.SetActive(false);
    }
}
