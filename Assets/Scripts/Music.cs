using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private bool isRadio;

    [SerializeField] private AudioClip[] ambienceClips;
    [SerializeField] private AudioClip[] radioClips;

    [SerializeField] private AudioSource audioSource;

    void Awake()
    {
        audioSource.clip = GetRandomClip();
        audioSource.Play();

        Invoke(nameof(EventOnEnd), audioSource.clip.length);
    }

    private AudioClip GetRandomClip()
    {
        if (isRadio)
        {
            return radioClips[UnityEngine.Random.Range(0, radioClips.Length)];
        }
        else
        {
            return ambienceClips[UnityEngine.Random.Range(0, ambienceClips.Length)];
        }
    }

    void EventOnEnd()
    {
        audioSource.clip = GetRandomClip();
        audioSource.Play();
    }
}
