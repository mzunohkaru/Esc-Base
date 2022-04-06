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
            //Box�ɃZ�b�g
            ItemBox.instance.SetItem(newItem);
            //Zoom��ʂɕ\��
            ZoomPanel.instance.ShowItem(newItem);
        }
    }
}
