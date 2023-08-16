using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Cloth, Fruit, Hat
}

[CreateAssetMenu(fileName = "ItemObject", menuName = "Item/ItemObject", order = 0)]
public class Item : ScriptableObject
{
    public string id;
    public Sprite icon;
    public int value;
    public ItemType itemType;
}
