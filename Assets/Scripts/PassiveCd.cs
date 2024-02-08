using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveCd : MonoBehaviour
{
    [SerializeField] private ClickerData _clickerData;
    [SerializeField] private ResourceData _resourceData;

    private float _timeRemaining;

    void Awake()
    {
        _timeRemaining = _clickerData.PassiveCooldown;
    }

    void Update()
    {
        if (_timeRemaining > 0)
        {
            _timeRemaining -= Time.deltaTime;
        }
        else
        {
            _resourceData.Resources += _clickerData.PassiveIncome;

            _timeRemaining = _clickerData.PassiveCooldown;
        }
    }
}
