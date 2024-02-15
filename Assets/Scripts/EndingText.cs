using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndingText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _endingTextBox;

    private void Awake()
    {
        _endingTextBox.text = EndingType.EndingArray[EndingType.EndingTypeProperty];
    }
}
