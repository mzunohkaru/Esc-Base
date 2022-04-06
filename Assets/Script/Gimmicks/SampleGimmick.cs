using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;

    // アイテム（Cube）を持っている状態で、クリックすると消える
    public void OnClickedObjRemove()
    {
        bool clear = ItemBox.instance.CheckSelectItem(clearItem);
        if (clear)
        {
            gameObject.SetActive(false);
        }
    }
}
