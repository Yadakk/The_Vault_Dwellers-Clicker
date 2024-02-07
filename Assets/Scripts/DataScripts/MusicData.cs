using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicData : MonoBehaviour
{
    [SerializeField] private bool _isRadio;

    [SerializeField] private AudioClip[] _ambience;
    [SerializeField] private AudioClip[] _radio;

    [SerializeField] private AudioSource _audioSource;

    public bool IsRadio
    {
        get => _isRadio;
        set => _isRadio = value;
    }

    public AudioSource AudioSource
    {
        get => _audioSource;
        set => _audioSource = value;
    }

    public AudioClip GetRandomMusic()
    {
        if (_isRadio)
        {
            return _radio[Random.Range(0, _radio.Length)];
        }
        else
        {
            return _ambience[Random.Range(0, _ambience.Length)];
        }
    }
}
