using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

public class ItemEquipmentContainerUI : MonoBehaviour, IDropHandler
{
    [SerializeField] ItemType equipmentSlotType;
    InventoryController inventoryController;

    private void Awake()
    {
        inventoryController = FindObjectOfType<InventoryController>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        GameObject droppedItem = eventData.pointerDrag;
        ItemUI droppedItemUI = droppedItem.GetComponent<ItemUI>();

        if (droppedItemUI.myItem.itemType == equipmentSlotType)
        {
            // if (droppedItemUI.myItem.itemType == ItemType.Cloth || droppedItemUI.myItem.itemType == ItemType.Hat)
            // {
            if (transform.childCount >= 1)
                Destroy(transform.GetChild(0).gameObject);
            droppedItem.transform.SetParent(transform);
            inventoryController.OnEquipedItem(droppedItemUI.myItem);
            droppedItemUI.equiped = true;
            //}
        }
        else
        {
            droppedItemUI.canvasGroup.blocksRaycasts = true;
        }
    }


}
