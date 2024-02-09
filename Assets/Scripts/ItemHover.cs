using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private TextMeshProUGUI _num;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        _img.color = new Color(255, 255, 255, 255);
        _num.color = new Color(0, 230, 0, 255);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        _img.color = new Color(255, 255, 255, 0);
        _num.color = new Color(0, 230, 0, 0);
    }
}
