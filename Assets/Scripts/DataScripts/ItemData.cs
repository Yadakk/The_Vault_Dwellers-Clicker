using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    [SerializeField] ItemData _itemData;
    [SerializeField] ResourceData _resourceData;
    [SerializeField] ClickerData _clickerData;

    private int _id;
    private int _cost;

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
        if (_resourceData.Resources >= _itemData.Cost && _clickerData.ClickLevel < 6)
        {
            _resourceData.Resources -= _itemData.Cost;

            switch (_clickerData.ClickLevel)
            {
                case 1:
                    _clickerData.ClickPower += 1;
                    _clickerData.ClickLevel++;
                    break;

                case 2:
                    _clickerData.ClickPower += 2;
                    _clickerData.ClickLevel++;
                    break;

                case 3:
                    _clickerData.ClickPower += 2;
                    _clickerData.ClickLevel++;
                    break;

                case 4:
                    _clickerData.ClickPower += 3;
                    _clickerData.ClickLevel++;
                    break;

                case 5:
                    _clickerData.ClickPower += 4;
                    _clickerData.ClickLevel++;
                    break;
            }
        }    
    }

    private void AutomatedBotsforRetrieval()
    {

    }
}
