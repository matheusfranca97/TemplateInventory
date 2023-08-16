using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] Image itemIconImage;
    [SerializeField] Text itemInformationText;

    CanvasGroup canvasGroup;
    public Item myItem;


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
        Debug.Log("terminei drag");
        canvasGroup.blocksRaycasts = true;
        GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
    }

}
