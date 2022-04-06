using UnityEngine;

[System.Serializable]   //インスペクターで表示される
public class Item
{
    //種類
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

    //Zoom時にPrefabから生成
    public GameObject zoomPrefab;

    public Item(Item item)
    {
        this.type = item.type;
        this.sprite = item.sprite;
    }
}
