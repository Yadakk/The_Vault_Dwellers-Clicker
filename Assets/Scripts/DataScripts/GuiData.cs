using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Search;
using UnityEngine;

public class GuiData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _resources;
    [SerializeField] private TextMeshProUGUI _essentials;
    [SerializeField] private TextMeshProUGUI _people;

    [SerializeField] private TextMeshProUGUI _year;
    [SerializeField] private TextMeshProUGUI _month;
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
}
