using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject itemUI;
    [SerializeField] private List<GameObject> itemContainers;
    [SerializeField] private GameObject equipedClothUI, equipedHatUI;


    public void OpenInventoryUI(List<Item> playerItens)
    {
        inventoryPanel.SetActive(true);

        for (int i = 0; i < playerItens.Count; i++)
        {
            if (itemContainers[i].transform.childCount >= 1)
                return;
            var newItemUI = Instantiate(itemUI, itemContainers[i].transform);
            newItemUI.GetComponent<ItemUI>().SetupItemUI(playerItens[i]);
        }
    }

    public void CloseInventoryUI()
    {
        inventoryPanel.SetActive(false);
    }

    public bool IsInventoryUIOpen()
    {
        return inventoryPanel.activeSelf;
    }

}
