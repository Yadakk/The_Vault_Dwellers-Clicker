using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private int monthDuration;

    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private TimeData _timeData;
    [SerializeField] private SfxData _sfxData;

    void Awake()
    {
        StartCoroutine(TimeCoroutine());
    }

    public void ContinueTimeCoroutine()
    {
        StartCoroutine(TimeCoroutine());
    }

    private IEnumerator TimeCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(monthDuration);
            _timeData.Month += 1;
            _audioSource.clip = _sfxData.MonthClip;

            if (_timeData.Month > 12)
            {
                _audioSource.clip = _sfxData.YearClip;
                _timeData.Month = 1;
                _timeData.Year += 1;
            }

            _audioSource.PlayOneShot(_audioSource.clip);
        }
    }
}
