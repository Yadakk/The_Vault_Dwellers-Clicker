using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;

public class EndingType : MonoBehaviour
{
    private static string[] _endingArray =
    {
        "After 5 years the environment outside the bunker has stopped being deadly. Your mission is now complete and you retire.",
        "Left without people, your bunker will decay for milleniums.",
    };

    private static int _endingType;

    public static string[] EndingArray
    {
        get => _endingArray;
        set => _endingArray = value;
    }

    public static int EndingTypeProperty
    {
        get => _endingType;
        set
        {
            _endingType = value;
        }
    }
}
