using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    #region Variables
    [SerializeField] private int monthDuration;

    [SerializeField] private TextMeshProUGUI yearLabel;
    [SerializeField] private TextMeshProUGUI timeLabel;

    [SerializeField] private AudioSource clockAudioSource;
    [SerializeField] private AudioClip monthAudio;
    [SerializeField] private AudioClip yearAudio;

    private static TextMeshProUGUI _yearLabel;
    private static TextMeshProUGUI _timeLabel;

    private TimeBank _timeObject;
    #endregion

    void Awake()
    {
        _timeObject = new TimeBank();

        _yearLabel = yearLabel;
        _timeLabel = timeLabel;

        StartCoroutine(TimeCoroutine());
    }

    private class TimeBank
    {
        #region Fields
        private int _year;
        private int _month = 1;
        #endregion

        #region Properties
        public int Year
        {
            get => _year;
            set
            {
                _year = value;
                _yearLabel.text = $"Year: {_year}";
            }
        }
        public int Month
        {
            get => _month;
            set
            {
                _month = value;
                _timeLabel.text = $"Month: {Mathf.Round(_month)}";
            }
        }
        #endregion
    }

    #region Coroutines
    private IEnumerator TimeCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(monthDuration);
            _timeObject.Month += 1;
            clockAudioSource.clip = monthAudio;
            if (_timeObject.Month > 12)
            {
                clockAudioSource.clip = yearAudio;
                _timeObject.Month = 1;
                _timeObject.Year += 1;
            }
            clockAudioSource.Play();
        }
    }
    #endregion
}
