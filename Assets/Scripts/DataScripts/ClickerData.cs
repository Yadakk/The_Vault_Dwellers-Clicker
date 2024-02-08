using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerData : MonoBehaviour
{
    [SerializeField] private int _clickPower;
    [SerializeField] private GuiData _guiData;

    public int ClickPower
    {
        get => _clickPower;
        set
        {
            _clickPower = value;
            _guiData.Power.text = $"Click power: {_clickPower}";
        }
    }
}
