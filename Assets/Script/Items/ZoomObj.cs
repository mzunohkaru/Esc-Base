using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomObj : MonoBehaviour
{
    public void OnClickObj()
    {
        Item newItem = ItemBox.instance.Synthetic(
            item0: Item.Type.BuleTile, 
            item1: Item.Type.YellowTile, 
            spawnItem: Item.Type.PinkTile);

        if (newItem != null) 
        {
            //Boxにセット
            ItemBox.instance.SetItem(newItem);
            //Zoom画面に表示
            ZoomPanel.instance.ShowItem(newItem);
        }
    }
}
