using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public static ItemBox instance;

    //���ׂĂ�Slot��c��
    [SerializeField] Slot[] slots;

    Slot selectSlot;
    Slot showSlot;  //�g��\�����Ă���A�C�e���̃X���b�g

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // �N���b�N���ꂽItem���󂯎��
    public void SetItem(Item item)
    {
        //���l�߂Ŋi�[
        for (int i = 0; i < slots.Length; i++)
        {
            if(slots[i].IsEmpty())
            {
                slots[i].Set(item);
                break;
            }
        }
    }

    //�X���b�g���N���b�N������
    public void OnSlotClick(int position)
    {
        //�I������X���b�g�ɃA�C�e�����Ȃ��ꍇ = �������Ȃ�
        if(slots[position].IsEmpty())
        {
            return;
        }

        //��x���ׂĂ𔒂ɂ���
        for (int i = 0; i < slots.Length; i++)
        {
            //slots[i]�̔w�i���\��
            slots[i].HideBackPanel();
        }

        //�N���b�N�����X���b�g�̔w�i�����ɂ���
        slots[position].OnSelected();

        //�I�����Ă���A�C�e�����擾
        selectSlot = slots[position];
    }

    //����I�����Ă��邩����
    public bool CheckSelectItem(Item.Type useItemType)
    {
        //�����I�����ĂȂ��ꍇ
        if (selectSlot == null)
        {
            return false;
        }
        //�I�������X���b�g�̒���Item����������
        if (selectSlot.GetItem().type == useItemType) 
        {
            return true;
        }
        return false;
    }


    public bool CheckShowItem(Item.Type useItemType)
    {
        //�����I�����ĂȂ��ꍇ
        if (showSlot == null)
        {
            return false;
        }
        //�I�������X���b�g�̒���Item����������
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

    //�I�𒆂̃A�C�e���擾
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
        //���ݑI�𒆂̃X���b�g���g��\���X���b�g�Ƃ���
        showSlot = selectSlot;
    }

    //Item����
    public Item Synthetic(Item.Type item0, Item.Type item1, Item.Type spawnItem)
    {
        //�g�咆 -> ItemBox.showSlot
        //�I�� -> ItemBox.selectSlot

        //Blue�g�咆��YellowTile�I�� or YellowTile�g�咆��Blue�I�� -> ����
        if ((CheckShowItem(item0) && CheckSelectItem(item1))
            || (CheckShowItem(item1) && CheckSelectItem(item0))
            )
        {
            //�g�咆���I�𒆂��폜
            UseSelectItem();
            UseShowItem();

            return ItemDatabase.instance.Spawn(spawnItem);
        }
        return null;
    }
}
