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

    void Awake()
    {
        InvokeRepeating("Cooldown", _monthDuration, _monthDuration);
    }
    public void Cooldown()
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

        if (_timeData.Year == 5)
        {
            EndingType.EndingTypeProperty = 0;
            ThrowGameOver();
        }
    }

    public void ThrowGameOver()
    {
        if (EndingType.EndingTypeProperty == 0)
            SaveData.Stars += 1;
        SaveData.Save();
        SceneManager.LoadScene("GameOverScreen");
    }
}
