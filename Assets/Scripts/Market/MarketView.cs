using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MarketView : MonoBehaviour
{

    [SerializeField] List<GameObject> marketItemContainers;
    [SerializeField]
    GameObject marketUIPanel;
    [SerializeField] GameObject itemUIPrefab;

    public void SetupItemContainers(List<Item> items)
    {
        marketUIPanel.SetActive(true);
        ClearMarketContainers();

        for (int i = 0; i < items.Count; i++)
        {
            var newItemUI = Instantiate(itemUIPrefab, marketItemContainers[i].transform);
            newItemUI.GetComponent<ItemUI>().SetupItemUI(items[i]);
            newItemUI.GetComponent<ItemUI>().forSale = true;
        }
    }

    public void ClearMarketContainers()
    {
        for (int i = 0; i < marketItemContainers.Count; i++)
        {
            if (marketItemContainers[i].transform.childCount >= 1)
            {
                Destroy(marketItemContainers[i].transform.GetChild(0).gameObject);
            }
        }
    }


}
