using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.PackageManager.UI;

public class Events : MonoBehaviour
{
    [SerializeField] private int _minSeconds = 60;
    [SerializeField] private int _maxSeconds = 120;

    [SerializeField] private TextMeshProUGUI _eMark;

    [SerializeField] private GameObject _windowClicker;
    [SerializeField] private GameObject _windowEvent;
    [SerializeField] private GuiSfx _guiSfx;

    private bool _hasEvent;

    private int _randomSeconds;
    private void Awake()
    {
        _randomSeconds = Random.Range(_minSeconds, _maxSeconds);
        Invoke("PushEvent", _randomSeconds);
    }
    
    public void PushEvent()
    {
        _eMark.color = new Color(230, 0, 0);
        _hasEvent = true;

        _randomSeconds = Random.Range(_minSeconds, _maxSeconds);
        Invoke("PushEvent", _randomSeconds);
    }

    public void OpenEvent()
    {
        if (_hasEvent)
        {
            _eMark.color = new Color(0, 230, 0);

            _guiSfx.OnButtonClick();
            _hasEvent = false;
            _windowClicker.SetActive(false);
            _windowEvent.SetActive(true);
        }
    }
}
