using UnityEngine;
using TMPro;

public class PathCompleter : MonoBehaviour
{
    [SerializeField] private TMP_Text _tapText;

    public void ShowText()
    {
        _tapText.gameObject.SetActive(true);
        enabled = false;
    }
}
