using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleAlgorithm : MonoBehaviour
{
    [SerializeField] private int _cooldown;
    [SerializeField] ResourceData _resourceData;
    private bool _isReady;

    public int Cooldown
    {
        get => _cooldown;
        set => _cooldown = value;
    }

    void Awake()
    {
        _isReady = true;
        PeopleCalculation();
    }

    IEnumerator PeopleCooldown()
    {
        yield return new WaitForSeconds(Cooldown);
        _isReady = true;
        PeopleCalculation();
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
                _resourceData.People -= (int)Mathf.Round((_resourceData.Resources / 100) * (_resourceData.Essentials / 10) * (_resourceData.People / 25) / 2);
            }
            _isReady = false;
            StartCoroutine("PeopleCooldown");
        }
    }
}
