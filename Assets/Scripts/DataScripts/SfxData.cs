using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SfxData : MonoBehaviour
{
    [SerializeField] private AudioClip[] _button;

    [SerializeField] private AudioClip _year;
    [SerializeField] private AudioClip _month;
    [SerializeField] private AudioClip _gameOver;

    [SerializeField] private AudioClip _guiOpen;
    [SerializeField] private AudioClip _guiClose;

    [SerializeField] private AudioSource _audioSource;

    public AudioClip[] ButtonClips
    {
        get => _button;
        set => _button = value;
    }

    public AudioSource AudioSource
    {
        get => _audioSource;
        set => _audioSource = value;
    }

    public AudioClip YearClip
    {
        get => _year;
        set => _year = value;
    }

    public AudioClip MonthClip
    {
        get => _month;
        set => _month = value;
    }
    public AudioClip GameOverClip
    {
        get => _gameOver;
        set => _gameOver = value;
    }

    public AudioClip GuiOpen
    {
        get => _guiOpen;
        set => _guiOpen = value;
    }

    public AudioClip GuiClose
    {
        get => _guiClose;
        set => _guiClose = value;
    }

    public AudioClip GetButtonClips()
    {
        return ButtonClips[Random.Range(0, ButtonClips.Length)];
    }
}
