using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rt;
    private CanvasGroup CG;
    private Vector2 originalPosition;

    public static bool checkedItem;

    private void Awake(){
        rt = GetComponent<RectTransform>();
        CG = GetComponent<CanvasGroup>();
        originalPosition = rt.anchoredPosition;
        checkedItem = false;
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("BeginDrag");
        CG.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData){
        rt.anchoredPosition += eventData.delta;
        Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("EndDrag");
        CG.blocksRaycasts = true;

        if(checkedItem == false){
            rt.anchoredPosition = originalPosition;
        }else{
            CG.blocksRaycasts = false;
        }
        checkedItem = false;
    }

    public void OnPointerDown(PointerEventData eventData){
        Debug.Log("Pointer");
    }
}
