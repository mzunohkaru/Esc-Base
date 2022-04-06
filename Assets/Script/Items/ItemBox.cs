using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public static ItemBox instance;

    //すべてのSlotを把握
    [SerializeField] Slot[] slots;

    Slot selectSlot;
    Slot showSlot;  //拡大表示しているアイテムのスロット

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // クリックされたItemを受け取る
    public void SetItem(Item item)
    {
        //左詰めで格納
        for (int i = 0; i < slots.Length; i++)
        {
            if(slots[i].IsEmpty())
            {
                slots[i].Set(item);
                break;
            }
        }
    }

    //スロットをクリックした時
    public void OnSlotClick(int position)
    {
        //選択するスロットにアイテムがない場合 = 何もしない
        if(slots[position].IsEmpty())
        {
            return;
        }

        //一度すべてを白にする
        for (int i = 0; i < slots.Length; i++)
        {
            //slots[i]の背景を非表示
            slots[i].HideBackPanel();
        }

        //クリックしたスロットの背景を黒にする
        slots[position].OnSelected();

        //選択しているアイテムを取得
        selectSlot = slots[position];
    }

    //鍵を選択しているか判定
    public bool CheckSelectItem(Item.Type useItemType)
    {
        //何も選択してない場合
        if (selectSlot == null)
        {
            return false;
        }
        //選択したスロットの中のItemが何か判定
        if (selectSlot.GetItem().type == useItemType) 
        {
            return true;
        }
        return false;
    }


    public bool CheckShowItem(Item.Type useItemType)
    {
        //何も選択してない場合
        if (showSlot == null)
        {
            return false;
        }
        //選択したスロットの中のItemが何か判定
        if (showSlot.GetItem().type == useItemType)
        {
            return true;
        }
        return false;
    }

    public void UseSelectItem()
    {
        selectSlot.RemoveItem();
        selectSlot = null;
    }

    public void UseShowItem()
    {
        showSlot.RemoveItem();
        showSlot = null;
    }

    //選択中のアイテム取得
    public Item GetSelectItem()
    {
        if (selectSlot == null)
        {
            return null;
        }

        return selectSlot.GetItem();
    }

    public void SetShowSlot()
    {
        //現在選択中のスロットを拡大表示スロットとする
        showSlot = selectSlot;
    }

    //Item合成
    public Item Synthetic(Item.Type item0, Item.Type item1, Item.Type spawnItem)
    {
        //拡大中 -> ItemBox.showSlot
        //選択中 -> ItemBox.selectSlot

        //Blue拡大中にYellowTile選択 or YellowTile拡大中にBlue選択 -> 合成
        if ((CheckShowItem(item0) && CheckSelectItem(item1))
            || (CheckShowItem(item1) && CheckSelectItem(item0))
            )
        {
            //拡大中＆選択中を削除
            UseSelectItem();
            UseShowItem();

            return ItemDatabase.instance.Spawn(spawnItem);
        }
        return null;
    }
}
