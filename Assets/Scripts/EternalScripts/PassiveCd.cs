using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PassiveCd : MonoBehaviour
{
    [SerializeField] private ClickerData _clickerData;
    [SerializeField] private ResourceData _resourceData;


    void Awake()
    {
        InvokeRepeating("Cooldown", 0, _clickerData.PassiveCooldown);
    }

    public void ReInvoke()
    {
        CancelInvoke("Cooldown");
        InvokeRepeating("Cooldown", 0, _clickerData.PassiveCooldown);
    }

    private void Cooldown()
    {
        _resourceData.Resources += _clickerData.PassiveIncome;
    }
}
