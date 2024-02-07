using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private MusicData _musicData;

    void Awake()
    {
        _musicData.AudioSource.clip = _musicData.GetRandomMusic();
        _musicData.AudioSource.Play();

        Invoke(nameof(_musicData.EventOnEnd), _musicData.AudioSource.clip.length);
    }
}
