using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] Image itemIconImage;
    [SerializeField] Text itemInformationText;

    public CanvasGroup canvasGroup;
    public Item myItem;

    public bool equiped = false;


    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    //OnEvent

    public void SetupItemUI(Item item)
    {
        myItem = item;
        itemIconImage.sprite = myItem.icon;
        itemIconImage.color = Color.white;
        itemInformationText.text = myItem.id + " VALUE: " + myItem.value;
    }

    public void OnPointerOver()
    {
        itemInformationText.transform.parent.gameObject.SetActive(true);
    }

    public void OnPointerExit()
    {
        itemInformationText.transform.parent.gameObject.SetActive(false);
    }

    public void Drag()
    {
        canvasGroup.blocksRaycasts = false;
        transform.position = Input.mousePosition;
    }

    public void EndDrag()
    {
        GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

        if (!equiped)
            canvasGroup.blocksRaycasts = true;

    }

}
