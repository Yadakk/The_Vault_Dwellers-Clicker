#region Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
#endregion
public class Bootstrapper : MonoBehaviour
{
    #region Serialized variables
    [SerializeField] private int monthDuration;
                
    [SerializeField] private TextMeshProUGUI resourcesLabel;
    [SerializeField] private TextMeshProUGUI essentialsLabel;
    [SerializeField] private TextMeshProUGUI peopleLabel;

    [SerializeField] private TextMeshProUGUI yearLabel;
    [SerializeField] private TextMeshProUGUI timeLabel;
    #endregion

    #region Serialized to static variables
    private static TextMeshProUGUI _resourcesLabel;
    private static TextMeshProUGUI _essentialsLabel;
    private static TextMeshProUGUI _peopleLabel;
    
    private static TextMeshProUGUI _yearLabel;
    private static TextMeshProUGUI _timeLabel;
    #endregion

    #region Normal variables
    private int _clickPower;
    #endregion

    #region Object variables
    private TimeBank _timeObject;
    private ResourceBank _resourceObject;
    #endregion

    void Awake()
    {
        #region Serialized to static realization
        _resourcesLabel = resourcesLabel;
        _essentialsLabel = essentialsLabel;
        _peopleLabel = peopleLabel;

        _yearLabel = yearLabel;
        _timeLabel = timeLabel;
        #endregion

        #region Normal realization
        _clickPower = 1;
        #endregion

        #region Object realization
        _resourceObject = new ResourceBank();
        _timeObject = new TimeBank();
        #endregion

        #region Start coroutines
        StartCoroutine(TimeCoroutine());
        #endregion
    }

    #region Events
    public void OnButtonClick()
    {
        _resourceObject.Resources += _clickPower;
    }
    #endregion

    #region Coroutines
    private IEnumerator TimeCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(monthDuration);
            _timeObject.Month += 1;
            if (_timeObject.Month > 12)
            {
                _timeObject.Month = 1;
                _timeObject.Year += 1;
            }
        }
    }
    #endregion
    private class ResourceBank
    {
        #region Fields
        private int _resources;
        private int _essentials;
        private int _people;
        #endregion

        #region Properties
        public int Resources
        {
            get => _resources;
            set
            {
                _resources = value;
                _resourcesLabel.text = $"Resources: {_resources}";
            }
        }
        public int Essentials
        {
            get => _essentials;
            set
            {
                _essentials = value;
                _essentialsLabel.text = $"Essentials: {_essentials}";
            }
        }
        public int People
        {
            get => _people;
            set
            {
                _people = value;
                _peopleLabel.text = $"Essentials: {_people}";
            }
        }
        #endregion
    }
    
    private class TimeBank
    {
        #region Fields
        private int _year;
        private int _month = 1;
        #endregion

        #region Properties
        public int Year
        {
            get => _year;
            set
            {
                _year = value;
                _yearLabel.text = $"Year: {_year}";
            }
        }
        public int Month
        {
            get => _month;
            set
            {
                _month = value;
                _timeLabel.text = $"Month: {Mathf.Round(_month)}";
            }
        }
        #endregion
    }
    
    private class ItemBank
    {
        #region Variables
        private string _name;
        private string _description;
        #endregion

        #region Properties
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        #endregion
    }
}