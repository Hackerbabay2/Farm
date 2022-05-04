using System.Collections;
using UnityEngine;
using TMPro;

public class CoinsGenerator : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _rewardCoin;
    [SerializeField] private Transform _grassContainer;
    [SerializeField] private TMP_Text _coinCount;
    [SerializeField] private float _count = 10;
    [SerializeField] private Transform _target;

    public float Count => _count;

    public void Generate()
    {
        if (_grassContainer.childCount > 0)
        {
            for (int i = 0; i < _count; i++)
            {
                GameObject coin = Instantiate(_rewardCoin,_spawnPoint);
                coin.GetComponent<MoveReward>().SetTarget(_target);
            }
        }
    }
}
