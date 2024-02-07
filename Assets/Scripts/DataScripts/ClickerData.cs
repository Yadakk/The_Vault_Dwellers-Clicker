using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerData : MonoBehaviour
{
    [SerializeField] private int _clickPower;
    [SerializeField] private int _clickLevel;
    
    public int ClickPower
    {
        get => _clickPower;
        set => _clickPower = value;
    }

    public int ClickLevel
    {
        get => _clickLevel;
        set => _clickLevel = value;
    }
}
