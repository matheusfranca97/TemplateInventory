using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryData : MonoBehaviour
{
    [SerializeField] private List<Item> allItens;
    public Item hatEquiped, clothEquiped;
    public int coin;

    public void AddItem(Item item)
    {
        allItens.Add(item);
    }

    public void RemoveItem(Item item)
    {
        if (allItens.Contains(item))
            allItens.Remove(item);
    }

    public void ClearItens()
    {
        allItens.Clear();
    }

    public List<Item> GetAllItens()
    {
        return allItens;
    }

}
