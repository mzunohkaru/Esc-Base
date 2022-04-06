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

    //Item生成
    public Item Spawn(Item.Type type)
    {
        foreach (Item itemData in ItemDatabaseEntity.items)
        {
            //データベースからTypeが一致するものを探す
            if (itemData.type == type) 
            {
                //生成
                return new Item(itemData);
            }
        }

        return null;
    }

    //ZoomItemを生成
    public GameObject CreateZoomItem(Item.Type itemType)
    {
        for (int i = 0; i < ItemDatabaseEntity.items.Count; i++) 
        {
            Item itemData = ItemDatabaseEntity.items[i];
            if (itemData.type == itemType)
            {
                //生成
                return Instantiate(itemData.zoomPrefab);
            }
        }

        return null;
    }
}
