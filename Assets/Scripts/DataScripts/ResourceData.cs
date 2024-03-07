using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class ResourceData : MonoBehaviour
{
    public readonly UnityEvent<int> ResourcesChanged = new UnityEvent<int>();
    public readonly UnityEvent<int> EssentialsChanged = new UnityEvent<int>();
    public readonly UnityEvent<int> PeopleChanged = new UnityEvent<int>();

    [SerializeField] private int _resources;
    [SerializeField] private int _essentials;

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
                ResourcesChanged.Invoke(_resources);
            }
            else
            {
                _resources = 0;
                ResourcesChanged.Invoke(_resources);
            }
        }
    }

    public int Essentials
    {
        get => _essentials;
        set
        {
            if (value >= 0 || value <= 100)
            {
                _essentials = value;
                EssentialsChanged.Invoke(_essentials);
            }
            else if (value < 0)
            {
                _essentials = 0;
                EssentialsChanged.Invoke(_essentials);
            }
            else
            {
                _essentials = 100;
                EssentialsChanged.Invoke(_essentials);
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
                PeopleChanged.Invoke(_people);
            }
            else
            {
                _people = 0;
                PeopleChanged.Invoke(_people);

                EndingType.EndingTypeProperty = 1;
                _timer.ThrowGameOver();
            }
        }
    }

    private void Awake()
    {
        People = UnityEngine.Random.Range(10, 26);
    }
}
