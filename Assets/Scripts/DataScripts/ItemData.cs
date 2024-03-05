using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    [SerializeField] ItemData _itemData;
    [SerializeField] ResourceData _resourceData;
    [SerializeField] ClickerData _clickerData;
    [SerializeField] GuiData _guiData;

    [SerializeField] GuiSfx _sfx;

    private Item _item;

    public Item Item
    {
        get => _item;
        set => _item = value;
    }

    public void Purchase()
    {
        if (_resourceData.Resources >= _item.Cost)
        {
            _resourceData.Resources -= _item.Cost;
            _sfx.OnButtonClick();

            switch (_item.Id)
            {
                case 1:
                    RetrievalDeviceUpgrade();
                    _item.Cost *= 2;
                    break;
                case 2:
                    AutomatedBotsforRetrieval();
                    _item.Cost = (int)Mathf.Round(_item.Cost*1.5f);
                    break;
            }
            _guiData.Effect.text = $"Effect: {_item.LevelEffect[_item.Level]}";
            _item.Level += 1;
        }
    }
    private void RetrievalDeviceUpgrade()
    {
        _clickerData.ClickPower += 1;
    }

    private void AutomatedBotsforRetrieval()
    {
        _clickerData.PassiveIncome += 1;
    }
    private void LuckyCharm()
    {
        _clickerData.CriticalChance += 1;
    }
}
