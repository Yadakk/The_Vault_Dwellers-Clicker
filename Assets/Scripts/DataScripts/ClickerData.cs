using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerData : MonoBehaviour
{
    [SerializeField] private int _clickPower;
    
    public int ClickPower
    {
        get => _clickPower;
        set => _clickPower = value;
    }
}
