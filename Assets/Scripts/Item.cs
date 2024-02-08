using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _image;
    [SerializeField] private int _cost;
    [SerializeField] private int _id;
    [SerializeField] private int _level = 1;

    [SerializeField] private GuiData _guiData;
    [SerializeField] private ItemData _itemData;

    public int Level
    {
        get => _level;
        set => _level = value;
    }

    public int Cost
    {
        get => _cost;
        set => _cost = value;
    }

    public void TransferInfo()
    {
        _guiData.Name.text = _name;
        _guiData.Description.text = _description;
        _guiData.Image.sprite = _image;
        _guiData.Cost.text = $"Cost: {_cost}";
        _guiData.Level.text = $"Current level: {_level}";

        _itemData.Cost = _cost;
        _itemData.Id = _id;
        _itemData.Level = _level;
        _itemData.Item = this;
    }
}
