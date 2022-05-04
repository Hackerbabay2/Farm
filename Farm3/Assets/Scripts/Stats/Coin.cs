using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private GameObject _grassContainer;
    [SerializeField] private CoinsGenerator _coinsGenerator;

    private float _count = 0;

    public float Count => _count;

    public void Reward(float count)
    {
        _count += count;
        _text.SetText(_count.ToString());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out RewardedCoin rewardedCoin))
        {
            Reward(Mathf.MoveTowards(0,_grassContainer.transform.childCount, _grassContainer.transform.childCount / _coinsGenerator.Count));
            Destroy(rewardedCoin.gameObject);
        }
    }
}
