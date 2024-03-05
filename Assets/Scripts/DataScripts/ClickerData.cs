using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerData : MonoBehaviour
{
    private int _clickPower = 1;
    private int _passiveIncome = 0;
    private int _passiveCooldown = 1;
    private int _criticalChance = 0;

    [SerializeField] private GuiData _guiData;
    [SerializeField] PassiveCd _passiveCd;

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
            _passiveCd.ReInvoke();
        }
    }

    public int CriticalChance
    {
        get => _criticalChance;
        set
        {
            _criticalChance = value;
            _guiData.CriticalCh.text = $"Critical Chance: {_criticalChance}";
        }
    }

    private void Start()
    {
        ClickPower += SaveData.Stars;
    }
}
