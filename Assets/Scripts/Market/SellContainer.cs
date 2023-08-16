using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

public class SellContainer : MonoBehaviour, IDropHandler
{
    InventoryController inventoryController;

    private void Awake()
    {
        inventoryController = FindObjectOfType<InventoryController>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedItem = eventData.pointerDrag;
        ItemUI droppedItemUI = droppedItem.GetComponent<ItemUI>();

        if (droppedItemUI.myItem.itemType != ItemType.Fruit)
        {
            return;
        }
        else
        {
            Debug.Log("larguei pumpkins aqui");
            Coin.instance.AddCoins(droppedItemUI.myItem.value);
            Destroy(droppedItem);
            inventoryController.RemoveItemFromInventory(droppedItemUI.myItem);
        }
    }
}
