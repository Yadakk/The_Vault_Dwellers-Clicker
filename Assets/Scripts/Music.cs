using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private MusicData _musicData;

    void Awake()
    {
        _musicData.AudioSource.clip = _musicData.GetRandomMusic();
        _musicData.AudioSource.Play();

        Invoke(nameof(EventOnEnd), _musicData.AudioSource.clip.length);
    }

    public void EventOnEnd()
    {
        _musicData.AudioSource.clip = _musicData.GetRandomMusic();
        _musicData.AudioSource.Play();

        Invoke(nameof(EventOnEnd), _musicData.AudioSource.clip.length);
    }

    public void OnRadioSwitch()
    {
        _musicData.IsRadio = !_musicData.IsRadio;

        CancelInvoke();

        _musicData.AudioSource.clip = _musicData.GetRandomMusic();
        _musicData.AudioSource.Play();

        Invoke(nameof(EventOnEnd), _musicData.AudioSource.clip.length);
    }

    public void OnMute()
    {
        _musicData.IsMute = !_musicData.IsMute;

        _musicData.AudioSource.volume = _musicData.MuteUnmuteMusic();
    }
}
