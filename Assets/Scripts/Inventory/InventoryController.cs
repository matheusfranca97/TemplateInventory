using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] InventoryData inventoryData;
    [SerializeField] InventoryView inventoryView;
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
}
