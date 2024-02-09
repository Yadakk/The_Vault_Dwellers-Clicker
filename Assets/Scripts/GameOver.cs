using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _gameOver;

    void Awake()
    {
        _audioSource.PlayOneShot(_gameOver);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        Application.Quit();
        SceneManager.LoadScene("Menu");
    }
}
