using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;
    [SerializeField] ItemDatabaseEntity ItemDatabaseEntity;
    


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //Item����
    public Item Spawn(Item.Type type)
    {
        foreach (Item itemData in ItemDatabaseEntity.items)
        {
            //�f�[�^�x�[�X����Type����v������̂�T��
            if (itemData.type == type) 
            {
                //����
                return new Item(itemData);
            }
        }

        return null;
    }

    //ZoomItem�𐶐�
    public GameObject CreateZoomItem(Item.Type itemType)
    {
        for (int i = 0; i < ItemDatabaseEntity.items.Count; i++) 
        {
            Item itemData = ItemDatabaseEntity.items[i];
            if (itemData.type == itemType)
            {
                //����
                return Instantiate(itemData.zoomPrefab);
            }
        }

        return null;
    }
}
