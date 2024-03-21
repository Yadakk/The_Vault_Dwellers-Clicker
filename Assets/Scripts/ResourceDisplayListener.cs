using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class ResourceDisplayListener : MonoBehaviour
{
    [SerializeField] private ResourceData _resourceData;
    TextMeshProUGUI[] _children;

    private void Awake()
    {
        _children = GetComponentsInChildren<TextMeshProUGUI>(true);

        _resourceData.ResourcesChanged.AddListener(UpdateResources);
        _resourceData.EssentialsChanged.AddListener(UpdateEssentials);
        _resourceData.PeopleChanged.AddListener(UpdatePeople);
    }

    private void UpdateResources(int val)
    {
        _children[(int)ChildNames.Resources].text = $"           {val}";
    }

    private void UpdateEssentials(int val)
    {
        _children[(int)ChildNames.Essentials].text = $"           {val}";
    }

    private void UpdatePeople(int val)
    {
        _children[(int)ChildNames.People].text = $"           {val}";
    }

    enum ChildNames
    {
        Resources = 0,
        Essentials = 1,
        People = 2,
    }
}