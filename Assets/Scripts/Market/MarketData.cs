using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketData : MonoBehaviour
{
    [SerializeField] private List<Item> vendorItens;
    public void AddItem(Item item)
    {
        vendorItens.Add(item);
    }

    public void RemoveItem(Item item)
    {
        if (vendorItens.Contains(item))
            vendorItens.Remove(item);
    }

    public void ClearItens()
    {
        vendorItens.Clear();
    }

    public List<Item> GetAllItens()
    {
        return vendorItens;
    }
}
