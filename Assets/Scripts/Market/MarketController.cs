using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketController : MonoBehaviour
{
    [SerializeField] MarketData marketData;
    [SerializeField] MarketView marketView;

    [SerializeField]
    InventoryController inventoryController;


    public void OnBuyItem(Item buyedItem, GameObject itemUIGameObject)
    {
        if (Coin.instance.GetCoins() >= buyedItem.value)
        {
            Destroy(itemUIGameObject);
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
