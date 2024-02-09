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

    [SerializeField] private GuiData _guiData;

    private bool _hasEvent;

    private int _randomSeconds;
    private int _randomEvent;

    private List<Event> _eventList;
    private void Awake()
    {
        _eventList = new List<Event>
        {
            new Event("ExampleName1", "ExampleDescription1", "ExampleOptionA1", "ExampleOptionB1", "ExampleEffectsA1", "ExampleEffectsB1"),
            new Event("ExampleName2", "ExampleDescription2", "ExampleOptionA2", "ExampleOptionB2", "ExampleEffectsA2", "ExampleEffectsB2"),
            new Event("ExampleName3", "ExampleDescription3", "ExampleOptionA3", "ExampleOptionB3", "ExampleEffectsA3", "ExampleEffectsB3"),
        };

        _randomSeconds = Random.Range(_minSeconds, _maxSeconds);
        _randomEvent = Random.Range(0, _eventList.Count);
        Invoke("PushEvent", _randomSeconds);
    }
    
    public void PushEvent()
    {
        _eMark.color = new Color(230, 0, 0);
        _hasEvent = true;

        _randomSeconds = Random.Range(_minSeconds, _maxSeconds);
        _randomEvent = Random.Range(0, _eventList.Count);
        Invoke("PushEvent", _randomSeconds);
    }

    public void OpenEvent()
    {
        if (_hasEvent)
        {
            _eMark.color = new Color(0, 230, 0);

            _guiSfx.OnButtonClick();

            _guiData.EventName.text = _eventList[_randomEvent].Name;
            _guiData.EventDescription.text = _eventList[_randomEvent].Description;
            _guiData.EventOption1.text = _eventList[_randomEvent].Option1;
            _guiData.EventOption2.text = _eventList[_randomEvent].Option2;
            _guiData.EventEffect1.text = _eventList[_randomEvent].Effect1;
            _guiData.EventEffect2.text = _eventList[_randomEvent].Effect2;

            _hasEvent = false;
            _windowClicker.SetActive(false);
            _windowEvent.SetActive(true);
        }
    }

    class Event
    {
        public string Name;
        public string Description;
        public string Option1;
        public string Option2;
        public string Effect1;
        public string Effect2;

        public Event(string name, string description, string option1, string option2, string effect1, string effect2)
        {
            Name = name;
            Description = description;
            Option1 = option1;
            Option2 = option2;
            Effect1 = effect1;
            Effect2 = effect2;
        }
    }
}
