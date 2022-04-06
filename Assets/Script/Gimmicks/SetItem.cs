using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetItem : MonoBehaviour
{
    [SerializeField] GameObject coinObj;

    public UnityEvent ClearEvent;   //�O������֐���o�^

    /* 
        �R�C����I��������ԂŁA�N���b�N
        -> �R�C�����g�p
        -> �R�C���o��
    */

    public void OnClickSimplePlate()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Coin))
        {
            //�R�C���d�l
            ItemBox.instance.UseSelectItem();

            SetCoin();

            ClearEvent.Invoke();
        }
    }

    void SetCoin()
    {
        coinObj.SetActive(true);
    }
}
