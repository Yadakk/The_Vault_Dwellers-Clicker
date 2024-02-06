#region Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
#endregion
public class Bootstrapper : MonoBehaviour
{
    #region Serialized variables
    [SerializeField] private TextMeshProUGUI resourcesLabel;
    [SerializeField] private TextMeshProUGUI essentialsLabel;
    [SerializeField] private TextMeshProUGUI peopleLabel;

    [SerializeField] private AudioSource sfxAudioSource;
    [SerializeField] private AudioClip[] sfxClips;
    #endregion

    #region Serialized to static variables
    private static TextMeshProUGUI _resourcesLabel;
    private static TextMeshProUGUI _essentialsLabel;
    private static TextMeshProUGUI _peopleLabel;
    #endregion

    #region Normal variables
    private int _clickPower;

    private Controlasset _controlAsset;
    #endregion

    #region Object variables
    private ResourceBank _resourceObject;
    #endregion

    void Awake()
    {
        #region Serialized to static realization
        _resourcesLabel = resourcesLabel;
        _essentialsLabel = essentialsLabel;
        _peopleLabel = peopleLabel;
        #endregion

        #region Normal realization
        _clickPower = 1;

        _controlAsset = new Controlasset();
        #endregion

        #region Object realization
        _resourceObject = new ResourceBank();
        #endregion

        #region Invoke events
        _controlAsset.Clicker.Enable();
        #endregion
    }

    #region Normal functions
    private AudioClip GetSFXClips()
    {
        return sfxClips[UnityEngine.Random.Range(0, sfxClips.Length)];
    }
    #endregion

    #region Events
    public void OnButtonClick()
    {
        _resourceObject.Resources += _clickPower;
        sfxAudioSource.clip = GetSFXClips();
        sfxAudioSource.Play();
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