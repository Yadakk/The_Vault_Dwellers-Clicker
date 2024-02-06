using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private Image buttonImage;

    void Awake()
    {
        buttonImage.alphaHitTestMinimumThreshold = 0.5f;
    }
}
