using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GrassMovement : MonoBehaviour
{
    [SerializeField] private float _force = 5;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.velocity = Vector3.right * _force;
    }
}
