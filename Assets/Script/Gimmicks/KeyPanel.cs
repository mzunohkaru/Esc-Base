using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPanel : MonoBehaviour
{
    [SerializeField] Chest chest;

    //���������ăN���b�N���ꂽ��J����
    public void OnClickKeyPanel()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Key))
        {
            ItemBox.instance.UseSelectItem();
            //�󔠂��J����
            chest.Open();
        }
        else
        {
            MessagePanel.instance.ShowPanel("�����������Ă���悤��...");
        }
    }
}
