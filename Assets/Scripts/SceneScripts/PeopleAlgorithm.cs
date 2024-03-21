using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleAlgorithm : MonoBehaviour
{
    [SerializeField] private int _cooldown;
    [SerializeField] ResourceData _resourceData;
    [SerializeField] ClickerData _clickerData;
    private bool _isReady;
    private int _forRnd;

    public int Cooldown
    {
        get => _cooldown;
        set => _cooldown = value;
    }

    void Awake()
    {
        _isReady = true;
        PeopleCalculation();
        StartCoroutine(StrangerCalculation());
    }

    IEnumerator PeopleCooldown()
    {
        yield return new WaitForSeconds(Cooldown);
        _isReady = true;
        PeopleCalculation();
    }
    IEnumerator StrangerCalculation()
    {
        yield return new WaitForSeconds(Random.Range(10,120));
        _forRnd = Random.Range(1,100);
        if (_forRnd <= _clickerData.StrangerChance)
        {
            _resourceData.People += Random.Range(0,500);
            _resourceData.Resources += Random.Range(0,10000);
            _resourceData.Essentials += Random.Range(0, 50);
        }
        StartCoroutine(StrangerCalculation());
    }

    private void PeopleCalculation()
    {
        if (_isReady)
        {
            Debug.Log($"It's ready (joining) {(int)Mathf.Round((_resourceData.Resources / 1000) * (_resourceData.Essentials / 20) * (_resourceData.People / 50))}");
            _resourceData.People += (int)Mathf.Round((_resourceData.Resources / 1000) * (_resourceData.Essentials / 20) * (_resourceData.People / 50));
            if (Random.Range(1,4) == 1)
            {
                Debug.Log($"It's ready (leaving) {(int)Mathf.Round((_resourceData.Resources / 1000) * (_resourceData.Essentials / 20) * (_resourceData.People / 50) / 2)}");
                int leaving = (int)Mathf.Round((_resourceData.Resources / 100) * (_resourceData.Essentials / 10) * (_resourceData.People / 25) / 2); ;
                _resourceData.People -= leaving;
                _resourceData.Resources += (leaving * _clickerData.Tip);
            }
            _isReady = false;
            StartCoroutine("PeopleCooldown");
        }
    }
}
