using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public enum ItemType
{
    Cloth, Fruit, Hat, Any
}

[CreateAssetMenu(fileName = "ItemObject", menuName = "Item/ItemObject", order = 0)]
public class Item : ScriptableObject
{
    public string id;
    public Sprite icon;
    public int value;
    public ItemType itemType;
    public SpriteLibraryAsset spriteLibraryAsset;
}
