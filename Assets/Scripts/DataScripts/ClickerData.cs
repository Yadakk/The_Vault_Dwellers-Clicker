using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerData : MonoBehaviour
{
    private int _clickPower = 1;
    private int _passiveIncome = 0;
    private int _passiveCooldown = 4;

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

    public int PassiveIncome
    {
        get => _passiveIncome;
        set
        {
            _passiveIncome = value;
            _guiData.Passive.text = $"Passive income: {_passiveIncome}";
        }
    }

    public int PassiveCooldown
    {
        get => _passiveCooldown;
        set
        {
            _passiveCooldown = value;
            _guiData.PassiveCd.text = $"Passive cooldown: {_passiveCooldown}";
        }
    }
}
