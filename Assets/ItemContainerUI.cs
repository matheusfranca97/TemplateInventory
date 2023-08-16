using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemContainerUI : MonoBehaviour, IDropHandler
{
    [SerializeField] private bool equipmentSlot;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        GameObject droppedItem = eventData.pointerDrag;
        ItemUI droppedItemUI = droppedItem.GetComponent<ItemUI>();


        if (equipmentSlot)
        {
            if (droppedItemUI.myItem.itemType == ItemType.Cloth || droppedItemUI.myItem.itemType == ItemType.Hat)
                droppedItem.transform.SetParent(transform);
        }
    }


}
