using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GuiData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _resources;
    [SerializeField] private TextMeshProUGUI _essentials;
    [SerializeField] private TextMeshProUGUI _people;

    [SerializeField] private TextMeshProUGUI _year;
    [SerializeField] private TextMeshProUGUI _month;

    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _cost;
    [SerializeField] private TextMeshProUGUI _level;
    [SerializeField] private TextMeshProUGUI _power;
    [SerializeField] private TextMeshProUGUI _passive;
    [SerializeField] private TextMeshProUGUI _critCh;
    [SerializeField] private TextMeshProUGUI _posCh;
    [SerializeField] private TextMeshProUGUI _buy;
    [SerializeField] private TextMeshProUGUI _effect;

    [SerializeField] private TextMeshProUGUI _eventName;
    [SerializeField] private TextMeshProUGUI _eventDescription;
    [SerializeField] private TextMeshProUGUI _eventOption1;
    [SerializeField] private TextMeshProUGUI _eventOption2;
    [SerializeField] private TextMeshProUGUI _eventEffect1;
    [SerializeField] private TextMeshProUGUI _eventEffect2;

    public TextMeshProUGUI Resources 
    { 
        get => _resources; 
        set => _resources = value;
    }

    public TextMeshProUGUI Essentials
    { 
        get => _essentials;
        set => _essentials = value;
    }

    public TextMeshProUGUI People 
    { 
        get => _people;
        set => _people = value;
    }

    public TextMeshProUGUI Year
    {
        get => _year;
        set => _year = value;
    }

    public TextMeshProUGUI Month
    {
        get => _month;
        set => _month = value;
    }

    public TextMeshProUGUI Name
    {
        get => _name;
        set => _name = value;
    }

    public TextMeshProUGUI Description
    {
        get => _description;
        set => _description = value;
    }

    public Image Image
    {
        get => _image;
        set => _image = value;
    }

    public TextMeshProUGUI Cost
    {
        get => _cost;
        set => _cost = value;
    }

    public TextMeshProUGUI Level
    {
        get => _level;
        set => _level = value;
    }

    public TextMeshProUGUI Power
    {
        get => _power;
        set => _power = value;
    }

    public TextMeshProUGUI Passive
    {
        get => _passive;
        set => _passive = value;
    }

    public TextMeshProUGUI CriticalCh
    {
        get => _critCh;
        set => _critCh = value;
    }
    public TextMeshProUGUI PositiveCh
    {
        get => _posCh;
        set => _posCh = value;
    }

    public TextMeshProUGUI Buy
    {
        get => _buy;
        set => _buy = value;
    }

    public TextMeshProUGUI Effect
    {
        get => _effect;
        set => _effect = value;
    }

    public TextMeshProUGUI EventName
    {
        get => _eventName;
        set => _eventName = value;
    }

    public TextMeshProUGUI EventDescription
    {
        get => _eventDescription;
        set => _eventDescription = value;
    }

    public TextMeshProUGUI EventOption1
    {
        get => _eventOption1;
        set => _eventOption1 = value;
    }

    public TextMeshProUGUI EventOption2
    {
        get => _eventOption2;
        set => _eventOption2 = value;
    }

    public TextMeshProUGUI EventEffect1
    {
        get => _eventEffect1;
        set => _eventEffect1 = value;
    }

    public TextMeshProUGUI EventEffect2
    {
        get => _eventEffect2;
        set => _eventEffect2 = value;
    }
}
