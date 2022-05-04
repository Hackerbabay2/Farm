using System.Collections;
using UnityEngine;

public class Loader : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    public IEnumerator Load()
    {
        while (transform.position != _target.position)
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
            yield return null;
        }
    }
}
