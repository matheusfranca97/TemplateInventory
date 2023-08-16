using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private GameObject itemUI;
    [SerializeField] private List<GameObject> itemContainers;


    public void OpenInventoryUI(List<Item> inventoryItens)
    {
        inventoryPanel.SetActive(true);
        SetupInventoryUI(inventoryItens);
    }

    void CleanItemContainers()
    {
        for (int i = 0; i < itemContainers.Count; i++)
        {
            if (itemContainers[i].transform.childCount >= 1)
            {
                Destroy(itemContainers[i].transform.GetChild(0).gameObject);
            }
        }
    }

    public void SetupInventoryUI(List<Item> inventoryItens)
    {
        CleanItemContainers();

        Debug.Log(inventoryItens.Count);
        for (int i = 0; i < inventoryItens.Count; i++)
        {
            var newItemUI = Instantiate(itemUI, itemContainers[i].transform);
            newItemUI.GetComponent<ItemUI>().SetupItemUI(inventoryItens[i]);
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
