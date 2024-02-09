using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetStars : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tmp; 

    void Start()
    {
        _tmp.text = $"Stars: {SaveData.Stars}";
    }
}
