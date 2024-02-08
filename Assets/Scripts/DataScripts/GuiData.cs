using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Search;
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
    [SerializeField] private TextMeshProUGUI _buy;

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

    public TextMeshProUGUI Buy
    {
        get => _buy;
        set => _buy = value;
    }
}
