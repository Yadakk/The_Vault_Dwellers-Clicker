using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    private static int _stars = 0;

    private static SaveData _saveData;

    public static int Stars
    {
        get => _stars;
        set
        {
            _stars = value;
        }
    }
    public static SaveData SaveDataInstance
    {
        get => _saveData;
        set => _saveData = value;
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause)
            Save();
    }
    private void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus)
            Save();
    }
    private void OnApplicationQuit()
    {
        Save();
    }

    public static void Save()
    {
        PlayerPrefs.SetInt("Stars", Stars);
        PlayerPrefs.Save();
    }

    public void Load()
    {
        Stars = PlayerPrefs.GetInt("Stars", 0);
    }

    void Awake()
    {
        Load();

        DontDestroyOnLoad(transform.gameObject);

        if (_saveData == null)
        {
            _saveData = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
