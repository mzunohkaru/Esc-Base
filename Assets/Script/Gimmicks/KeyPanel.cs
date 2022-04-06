using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPanel : MonoBehaviour
{
    [SerializeField] Chest chest;

    //鍵を持ってクリックされたら開ける
    public void OnClickKeyPanel()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Key))
        {
            ItemBox.instance.UseSelectItem();
            //宝箱を開ける
            chest.Open();
        }
        else
        {
            MessagePanel.instance.ShowPanel("鍵がかかっているようだ...");
        }
    }
}
