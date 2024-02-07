using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeData : MonoBehaviour
{
    [SerializeField] private int _year;
    [SerializeField] private int _month;

    [SerializeField] private GuiData _guiData;

    public int Year
    {
        get => _year;
        set
        {
            _year = value;
            _guiData.Year.text = $"Year: {_year}";
        }
    }

    public int Month
    {
        get => _month;
        set
        {
            _month = value;
            _guiData.Month.text = $"Month: {_month}";
        }
    }
}
