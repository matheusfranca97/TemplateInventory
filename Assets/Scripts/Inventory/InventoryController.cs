using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] InventoryData inventoryData;
    [SerializeField] InventoryView inventoryView;

    [SerializeField] PlayerEquipmentHandler playerEquipmentHandler;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            if (!inventoryView.IsInventoryUIOpen())
            {
                inventoryView.OpenInventoryUI(inventoryData.GetAllItens());
            }
            else
            {
                inventoryView.CloseInventoryUI();
            }
        }
    }

    public void OnEquipedItem(Item equipedItem)
    {
        DesequipCurrentEquipment(equipedItem.itemType);
        EquipNewEquipment(equipedItem);
        inventoryView.SetupInventoryUI(inventoryData.GetAllItens());
        playerEquipmentHandler.OnNewEquipment(equipedItem);
    }

    void EquipNewEquipment(Item equipItem)
    {
        if (equipItem.itemType == ItemType.Cloth)
        {
            inventoryData.clothEquiped = equipItem;
        }

        if (equipItem.itemType == ItemType.Hat)
        {
            inventoryData.hatEquiped = equipItem;
        }
        inventoryData.RemoveItem(equipItem);
    }


    //Change
    void DesequipCurrentEquipment(ItemType itemType)
    {
        if (itemType == ItemType.Cloth)
        {
            if (inventoryData.clothEquiped)
                inventoryData.AddItem(inventoryData.clothEquiped);
            //inventoryData.clothEquiped = null;
        }

        if (itemType == ItemType.Hat)
        {
            if (inventoryData.hatEquiped)
                inventoryData.AddItem(inventoryData.hatEquiped);
            //inventoryData.hatEquiped = null;
        }
    }
}
