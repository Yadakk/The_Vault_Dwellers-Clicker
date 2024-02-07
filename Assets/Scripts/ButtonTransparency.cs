using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTransparency : MonoBehaviour
{
    [SerializeField] private Image buttonImage;

    void Awake()
    {
        buttonImage.alphaHitTestMinimumThreshold = 0.5f;
    }
}
