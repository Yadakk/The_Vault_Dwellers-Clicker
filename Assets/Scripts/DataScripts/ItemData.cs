using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    [SerializeField] ItemData _itemData;
    [SerializeField] ResourceData _resourceData;
    [SerializeField] ClickerData _clickerData;
    [SerializeField] GuiSfx _sfx;

    [SerializeField] GameObject _window;

    private int _id;
    private int _cost;
    private int _level;

    private Item _item;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int Cost
    {
        get => _cost;
        set => _cost = value;
    }

    public int Level
    {
        get => _level;
        set => _level = value;
    }

    public Item Item
    {
        get => _item;
        set => _item = value;
    }

    public void Purchase()
    {
        switch (_itemData.Id)
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
        if (_resourceData.Resources >= _itemData.Cost && _itemData.Level < 6)
        {
            _resourceData.Resources -= _itemData.Cost;
            _item.Level += 1;
            _window.SetActive(false);
            _sfx.OnButtonClick();

            switch (_itemData.Level)
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
        }    
    }

    private void AutomatedBotsforRetrieval()
    {

    }
}
