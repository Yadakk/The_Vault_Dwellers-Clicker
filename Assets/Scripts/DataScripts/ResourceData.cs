using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ResourceData : MonoBehaviour
{
    [SerializeField] private int _resources;
    [SerializeField] private int _essentials;
    [SerializeField] private int _people;

    [SerializeField] private GuiData _guiData;

    public int Resources
    {
        get => _resources;
        set
        {
            _resources = value;
            _guiData.Resources.text = $"Resources: {_resources}";
        }
    }

    public int Essentials
    {
        get => _essentials;
        set
        {
            _essentials = value;
            _guiData.Essentials.text = $"Essentials: {_essentials}";
        }
    }

    public int People
    {
        get => _people;
        set
        {
            _people = value;
            _guiData.People.text = $"People: {_people}";
        }
    }
}
