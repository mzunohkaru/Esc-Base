using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    //�A�C�e���̎�ނ�ݒ�
    public Item.Type type;

    public void OnClickObj()
    {
        //�f�[�^�x�[�X����Item����
        Item item = ItemDatabase.instance.Spawn(type);
        //�A�C�e��Box�ɔz�u
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);

        //MessagePanel.instance.ShowPanel(GetMessage(type));
    }

    /*
    string GetMessage(Item.Type type)
    {
        switch (type)
        {
            default:
            case Item.Type.BuleTile:
                return "���^�C������ɓ��ꂽ";
            case Item.Type.YellowTile:
                return "���F�̃^�C������ɓ��ꂽ";
            case Item.Type.RedTile:
                return "�Ԃ��^�C������ɓ��ꂽ";
            case Item.Type.Key:
                return "������ɓ��ꂽ";
            case Item.Type.Coin:
                return "�R�C������ɓ��ꂽ";
        }
    }
    */
}

