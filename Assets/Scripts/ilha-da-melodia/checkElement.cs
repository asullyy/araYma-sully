using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class checkElement : MonoBehaviour, IDropHandler
{

    public bool checkedTrue = false;

    public void OnDrop(PointerEventData eventData){
        if (eventData.pointerDrag != null){
            if(eventData.pointerDrag.gameObject.tag.Equals(gameObject.tag)){
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

                dragDrop.checkedItem = true;
                checkedTrue = true;
            }
        }
    }
}
