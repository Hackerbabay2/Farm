using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Slider;

    public void OnValueChanged(float currentValue, float maxValue)
    {
        Slider.value = currentValue / maxValue;
    }
}
