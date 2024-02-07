using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicData : MonoBehaviour
{
    [SerializeField] private bool _isRadio;

    [SerializeField] private AudioClip[] _ambience;
    [SerializeField] private AudioClip[] _radio;

    [SerializeField] private AudioSource _audioSource;

    public AudioSource AudioSource
    {
        get => _audioSource;
        set => _audioSource = value;
    }
    public AudioClip GetRandomMusic()
    {
        if (_isRadio)
        {
            return _radio[UnityEngine.Random.Range(0, _radio.Length)];
        }
        else
        {
            return _ambience[UnityEngine.Random.Range(0, _ambience.Length)];
        }
    }

    public void EventOnEnd()
    {
        _audioSource.clip = GetRandomMusic();
        _audioSource.PlayOneShot(_audioSource.clip);
    }
}
