using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    //アイテムの種類を設定
    public Item.Type type;

    public void OnClickObj()
    {
        //データベースからItem生成
        Item item = ItemDatabase.instance.Spawn(type);
        //アイテムBoxに配置
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);

        //MessagePanel.instance.ShowPanel(GetMessage(type));
    }

    /*
    string GetMessage(Item.Type type)
    {
        switch (type)
        {
            default:
            case Item.Type.BuleTile:
                return "青いタイルを手に入れた";
            case Item.Type.YellowTile:
                return "黄色のタイルを手に入れた";
            case Item.Type.RedTile:
                return "赤いタイルを手に入れた";
            case Item.Type.Key:
                return "鍵を手に入れた";
            case Item.Type.Coin:
                return "コインを手に入れた";
        }
    }
    */
}

