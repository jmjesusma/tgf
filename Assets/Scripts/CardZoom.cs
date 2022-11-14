using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{

    public GameObject Canvas;

    private GameObject zoomCard;

    public void OnHoverEnter() {
        zoomCard=Instantiate(gameObject, new Vector2(Input.mousePosition.x,Input.mousePosition.y+100),Quaternion.identity);
        zoomCard.transform.SetParent(Canvas.transform, true);
        zoomCard.layer=LayerMask.NameToLayer("Zoom");
        RectTransform rect= zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta= new Vector2(240, 340);
    }
    public void OnHoverExit()
    {
        Destroy(zoomCard);
    }
}
