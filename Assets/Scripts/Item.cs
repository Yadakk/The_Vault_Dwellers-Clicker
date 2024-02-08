using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private int _id;
    [SerializeField] private int[] _levelCost;

    [SerializeField] private Sprite _image;

    [SerializeField] private GuiData _guiData;
    [SerializeField] private ItemData _itemData;

    [SerializeField] private TextMeshProUGUI _num;

    private int _cost;
    private int _level;

    public int Level
    {
        get => _level;
        set
        {
            _level = value;
            _guiData.Level.text = $"Current level: {_level}";
        }
    }

    public int Cost
    {
        get => _cost;
        set
        {
            _cost = value;
            _guiData.Cost.text = $"Cost: {_cost}";
            _num.text = _cost.ToString();
        }
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int[] LevelCost
    {
        get => _levelCost;
        set => _levelCost = value;
    }

    public TextMeshProUGUI Num
    {
        get => _num;
        set => _num = value;
    }

    public void TransferInfo()
    {
        _guiData.Name.text = _name;
        _guiData.Description.text = _description;
        _guiData.Image.sprite = _image;
        _guiData.Level.text = $"Current level: {_level}";

        _itemData.Item = this;

        if (_level < LevelCost[LevelCost.Length - 1])
        {
            _guiData.Buy.text = "Buy";
            _guiData.Cost.text = $"Cost: {_cost}";
        }
        else
        {
            _guiData.Buy.text = "Sold out";
            _guiData.Cost.text = $"Cost: -";
        }
    }
    private void Awake()
    {
        _level = 1;
        _cost = _levelCost[0];

        _num.text = _cost.ToString();
    }
}
