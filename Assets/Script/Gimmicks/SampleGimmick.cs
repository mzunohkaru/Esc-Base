using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;

    // �A�C�e���iCube�j�������Ă����ԂŁA�N���b�N����Ə�����
    public void OnClickedObjRemove()
    {
        bool clear = ItemBox.instance.CheckSelectItem(clearItem);
        if (clear)
        {
            gameObject.SetActive(false);
        }
    }
}
