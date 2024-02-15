using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class Events : MonoBehaviour
{
    [SerializeField] private int _minSeconds = 60;
    [SerializeField] private int _maxSeconds = 120;

    [SerializeField] private TextMeshProUGUI _eMark;

    [SerializeField] private GameObject _windowClicker;
    [SerializeField] private GameObject _windowEvent;

    [SerializeField] private GuiSfx _guiSfx;

    [SerializeField] private GuiData _guiData;
    [SerializeField] private ResourceData _resourceData;
    [SerializeField] private TimeData _timeData;

    private bool _hasEvent;

    private int _randomSeconds;
    private int _randomEvent;

    private List<Event> _eventList;
    private void Awake()
    {
        _eventList = new List<Event>
        {
            new Event("Boredom", "People in your bunker are complaining about the lack of entertaiment options and want you to make a cinema hall", "Listen", "Ignore", "-100 Caps, +20 People", "-20 People"),
            new Event("Attack on Bunkers", "Your bunker has been a subject to attacks from irradiated monsters. Your people are begging you to set up defences", "Listen", "Ignore", "-200 Caps, -15 Breads, +50 People", "+20 Breads, -75 People"),
            new Event("Fridge is empty", "Your bunker has been low on essential resources for a while and your people have been starving", "Listen", "Ignore", "+25 Breads", "-50 People"),
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

    public void Option1()
    {
        switch (_randomEvent)
        {
            case 0:
                _resourceData.Resources -= 100;
                _resourceData.People += 20;
                break;

            case 1:
                _resourceData.Resources -= 200;
                _resourceData.Essentials -= 15;
                _resourceData.People -= 50;
                break;

            case 2:
                _resourceData.Essentials += 25;
                break;
        }
    }

    public void Option2()
    {
        switch (_randomEvent)
        {
            case 0:
                _resourceData.People -= 20;
                break;

            case 1:
                _resourceData.Essentials += 20;
                _resourceData.People -= 75;
                break;

            case 2:
                _resourceData.People -= 50;
                break;
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
