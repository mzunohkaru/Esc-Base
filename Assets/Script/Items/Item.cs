using UnityEngine;

[System.Serializable]   //�C���X�y�N�^�[�ŕ\�������
public class Item
{
    //���
    public enum Type
    {
        RedTile,
        BuleTile,
        YellowTile,
        PinkTile,
        Key,
        Coin
    }
    public Type type;

    public Sprite sprite;

    //Zoom����Prefab���琶��
    public GameObject zoomPrefab;

    public Item(Item item)
    {
        this.type = item.type;
        this.sprite = item.sprite;
    }
}
