using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _gameOver;

    public AudioSource AudioSource
    {
        get => _audioSource;
        set => _audioSource = value;
    }
    public AudioClip GameOverClip
    {
        get => _gameOver;
        set => _gameOver = value;
    }
    void Start()
    {
        _audioSource.PlayOneShot(_gameOver);
    }

    
    public void doQuitGame()
    {
        Application.Quit();
        Debug.Log("quit game");
    }
}
