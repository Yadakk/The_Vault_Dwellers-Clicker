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
        switch (_item.Id)
        {
            case 1:
                RetrievalDeviceUpgrade();
                break;
            case 2:
                AutomatedBotsforRetrieval();
                break;
        }
    }
    private void RetrievalDeviceUpgrade()
    {
        if (_resourceData.Resources >= _item.Cost && _item.Level <= _item.LevelCost.Length)
        {
            _resourceData.Resources -= _item.Cost;
            _sfx.OnButtonClick();

            switch (_item.Level)
            {
                case 1:
                    _clickerData.ClickPower += 1;
                    break;

                case 2:
                    _clickerData.ClickPower += 2;
                    break;

                case 3:
                    _clickerData.ClickPower += 2;
                    break;

                case 4:
                    _clickerData.ClickPower += 3;
                    break;

                case 5:
                    _clickerData.ClickPower += 4;
                    break;
            }
            if (_item.Level < _item.LevelCost.Length)
                _item.Cost = _item.LevelCost[_item.Level];
            else
            {
                _guiData.Buy.text = "Sold out";
                _guiData.Cost.text = $"Cost: -";
                _item.Num.text = "-";
            }

            _item.Level += 1;
        }    
    }

    private void AutomatedBotsforRetrieval()
    {

    }
}
