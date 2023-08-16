using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] Image itemIconImage;
    [SerializeField] Text itemInformationText;

    public CanvasGroup canvasGroup;
    public Item myItem;

    public bool equiped = false, forSale = false;



    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void SetupItemUI(Item item)
    {
        myItem = item;
        itemIconImage.sprite = myItem.icon;
        itemIconImage.color = Color.white;
        itemInformationText.text = myItem.id + " PRICE: " + myItem.value;
    }

    public void OnPointerOver()
    {
        itemInformationText.transform.parent.gameObject.SetActive(true);
    }

    public void OnPointerExit()
    {
        itemInformationText.transform.parent.gameObject.SetActive(false);
    }


    Transform originalParent;
    public void OnStartDrag()
    {
        originalParent = transform.parent;
        transform.SetParent(FindObjectOfType<Canvas>().transform);
    }

    public void Drag()
    {
        canvasGroup.blocksRaycasts = false;
        transform.position = Input.mousePosition;
    }

    public void EndDrag()
    {
        if (transform.parent == FindObjectOfType<Canvas>().transform)
            transform.SetParent(originalParent);
        GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        if (!equiped)
            canvasGroup.blocksRaycasts = true;
    }

}
