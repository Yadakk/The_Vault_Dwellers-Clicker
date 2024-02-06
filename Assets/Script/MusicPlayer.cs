using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] AmbienceClips;
    public AudioClip[] RadioClips;
    [SerializeField] private bool IsRadio;
    [SerializeField] private AudioSource audioSource;
    void Start()
    {
        audioSource.loop = false;
    }

    private AudioClip GetRandomClip()
    {

        if (IsRadio)
        {
            return RadioClips[Random.Range(0, RadioClips.Length)];
        }
        else
        {
            return AmbienceClips[Random.Range(0, AmbienceClips.Length)];
        }
    }
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }
}
