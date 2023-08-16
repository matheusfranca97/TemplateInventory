using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{

    bool playerIsClose;
    InventoryData playerInventory;
    [SerializeField] Item item;


    private void Awake()
    {
        playerInventory = FindObjectOfType<InventoryData>();
    }
    public void PickUp()
    {
        playerInventory.AddItem(item);
        Destroy(this.gameObject);
    }


    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (playerIsClose)
                PickUp();
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
            playerIsClose = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
            playerIsClose = false;
    }
}
