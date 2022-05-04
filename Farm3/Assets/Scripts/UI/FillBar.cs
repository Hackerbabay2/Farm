using UnityEngine;

public class FillBar : Bar
{
    [SerializeField] private GrassFiller _grassFiller;

    private void OnEnable()
    {
        _grassFiller.IsAdded += OnValueChanged;
    }

    private void OnDisable()
    {
        _grassFiller.IsAdded -= OnValueChanged;
    }
}
