using UnityEngine;
using TMPro;

public class SetCount : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinCount;
    [SerializeField] private Transform _grassContainer;

    public void Set()
    {
        _coinCount.text = _grassContainer.childCount.ToString();
    }

    private void OnEnable()
    {
        Set();
    }
}
