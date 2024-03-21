using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ResourceData : MonoBehaviour
{
    [SerializeField] private int _resources;
    [SerializeField] private int _essentials;
    private int _maxEssentials = 100;

    [SerializeField] private GuiData _guiData;

    [SerializeField] private Timer _timer;

    private int _people;

    public int Resources
    {
        get => _resources;
        set
        {
            if (value >= 0)
            {
                _resources = value;
                _guiData.Resources.text = $"           {_resources}";
            }
            else
            {
                _resources = 0;
                _guiData.Resources.text = $"           {_resources}";

            }
        }
    }

    public int Essentials
    {
        get => _essentials;
        set
        {
            if (value >= 0 || value <= _maxEssentials)
            {
                _essentials = value;
                _guiData.Essentials.text = $"           {_essentials}%";
            }
            else if (value < 0)
            {
                _essentials = 0;
                _guiData.Essentials.text = $"           {_essentials}%";

            }
            else
            {
                _essentials = _maxEssentials;
                _guiData.Essentials.text = $"           {_essentials}%";
            }
        }
    }

    public int People
    {
        get => _people;
        set
        {
            if (value >= 0 && value <= Int32.MaxValue-1)
            {
                _people = value;
                _guiData.People.text = $"           {_people}";
            }
            else
            {
                _people = 0;
                _guiData.People.text = $"           {_people}";

                EndingType.EndingTypeProperty = 1;
                _timer.ThrowGameOver();
            }
        }
    }
    public int MaxEssentials
    {
        get => _maxEssentials;
        set => _maxEssentials = value;
    }

    private void Awake()
    {
        People = UnityEngine.Random.Range(10, 26);
    }
}
