using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketController : MonoBehaviour
{
    [SerializeField] MarketData marketData;
    [SerializeField] MarketView marketView;

    [SerializeField]
    InventoryController inventoryController;

    public void OnSellItem(Item selledItem)
    {
        Debug.Log("vendi um item");
    }

    public void OnBuyItem(Item buyedItem)
    {
        if (Coin.instance.GetCoins() >= buyedItem.value)
        {
            Coin.instance.RemoveCoins(buyedItem.value);
            inventoryController.AddItemToInventory(buyedItem);
            marketData.RemoveItem(buyedItem);
            marketView.SetupItemContainers(marketData.GetAllItens());
        }
    }

    public void OpenMarket()
    {
        inventoryController.OpenInventory();
        marketView.SetupItemContainers(marketData.GetAllItens());
    }



}
