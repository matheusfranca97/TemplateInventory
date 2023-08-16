using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class PlayerEquipmentHandler : MonoBehaviour
{

    [SerializeField] SpriteLibrary hatSpriteLibrary, clothSpriteLibrary;


    public void OnNewEquipment(Item equipmentItem)
    {
        switch (equipmentItem.itemType)
        {
            case ItemType.Cloth:
                SetupNewEquipment(clothSpriteLibrary, equipmentItem.spriteLibraryAsset);
                break;
            case ItemType.Hat:
                SetupNewEquipment(hatSpriteLibrary, equipmentItem.spriteLibraryAsset);
                break;
        }
    }

    void SetupNewEquipment(SpriteLibrary spriteLibrary, SpriteLibraryAsset spriteLibraryAsset)
    {
        spriteLibrary.gameObject.SetActive(true);
        spriteLibrary.spriteLibraryAsset = spriteLibraryAsset;
    }
}
