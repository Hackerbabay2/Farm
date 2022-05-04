using System.Collections;
using UnityEngine;

public class GrassLifeTime : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Coroutine _startLife; 

    private void OnEnable()
    {
        _startLife = StartCoroutine(Life(_duration));
    }

    private void OnDisable()
    {
        StopCoroutine(_startLife);
    }

    private IEnumerator Life(float duration)
    {
        WaitForSeconds wait = new WaitForSeconds(duration);
        yield return wait;
        gameObject.SetActive(false);
    }
}
