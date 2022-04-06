using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetItem : MonoBehaviour
{
    [SerializeField] GameObject coinObj;

    public UnityEvent ClearEvent;   //外部から関数を登録

    /* 
        コインを選択した状態で、クリック
        -> コインを使用
        -> コイン出現
    */

    public void OnClickSimplePlate()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Coin))
        {
            //コイン仕様
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
