using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

public class ItemContainerUI : MonoBehaviour, IDropHandler
{
    [SerializeField] private ItemType equipmentSlotType;
    private MarketController marketController;
    private InventoryController inventoryController;

    private void Awake()
    {
        inventoryController = FindObjectOfType<InventoryController>();
        marketController = FindObjectOfType<MarketController>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedItem = eventData.pointerDrag;
        ItemUI droppedItemUI = droppedItem.GetComponent<ItemUI>();

        if (droppedItemUI.myItem.itemType == equipmentSlotType)
        {
            if (droppedItemUI.forSale)
                return;

            if (transform.childCount >= 1)
                Destroy(transform.GetChild(0).gameObject);
            droppedItem.transform.SetParent(transform);
            inventoryController.OnEquipedItem(droppedItemUI.myItem);
            droppedItemUI.equiped = true;
        }
        else if (droppedItemUI.forSale)
        {
            marketController.OnBuyItem(droppedItemUI.myItem, droppedItem);
            //inventoryController.AddItemToInventory(droppedItemUI.myItem);
        }
        else
        {
            droppedItemUI.canvasGroup.blocksRaycasts = true;
        }
    }


}
