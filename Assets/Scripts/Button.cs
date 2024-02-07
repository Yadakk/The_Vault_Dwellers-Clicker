using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private Image buttonImage;

    [SerializeField] private ResourceData _resourceData;
    [SerializeField] private SfxData _sfxData;
    [SerializeField] private ClickerData _clickerData;

    void Awake()
    {
        buttonImage.alphaHitTestMinimumThreshold = 0.5f;
    }
    public void OnButtonClick()
    {
        _resourceData.Resources += _clickerData.ClickPower;

        _sfxData.AudioSource.clip = _sfxData.GetButtonClips();
        _sfxData.AudioSource.PlayOneShot(_sfxData.AudioSource.clip);
    }
}
