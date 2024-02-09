using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiSfx : MonoBehaviour
{
    [SerializeField] private bool _open;
    [SerializeField] private SfxData _sfxData;

    public void OnButtonClick()
    {
        if (_open)
            _sfxData.AudioSource.PlayOneShot(_sfxData.GuiOpen);
        else
            _sfxData.AudioSource.PlayOneShot(_sfxData.GuiClose);
    }
    public void OnButtonClickForEvents()
    {
        if (_open)
            _sfxData.AudioSource.PlayOneShot(_sfxData.KarmaUp);
        else
            _sfxData.AudioSource.PlayOneShot(_sfxData.KarmaDown);
    }
}