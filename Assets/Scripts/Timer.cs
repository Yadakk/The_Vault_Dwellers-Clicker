using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private int _monthDuration;

    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private TimeData _timeData;
    [SerializeField] private SfxData _sfxData;

    private float _timeRemaining;

    void Awake()
    {
        _timeRemaining = _monthDuration;
    }
    private void Update()
    {
        if (_timeRemaining > 0)
        {
            _timeRemaining -= Time.deltaTime;
        }
        else
        {
            _timeData.Month += 1;

            _audioSource.clip = _sfxData.MonthClip;

            if (_timeData.Month > 12)
            {
                _audioSource.clip = _sfxData.YearClip;
                _timeData.Month = 1;
                _timeData.Year += 1;
            }

            _audioSource.PlayOneShot(_audioSource.clip);

            _timeRemaining = _monthDuration;

            if (_timeData.Year == 5)
            {
                SceneManager.LoadScene("GameOverScreen");
            }
        }
    }
}
