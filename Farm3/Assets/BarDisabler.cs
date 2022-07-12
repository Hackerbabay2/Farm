using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarDisabler : MonoBehaviour
{
    [SerializeField] private GameObject _fillBar;

    public void OnEnable()
    {
        _fillBar.SetActive(false);
    }

    public void OnDisable()
    {
        _fillBar.SetActive(true);
    }
}
