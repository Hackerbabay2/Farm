using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private FixedJoystick _fixedJoystick;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_fixedJoystick.Horizontal != 0 || _fixedJoystick.Vertical != 0)
        {
            Vector3 direction = new Vector3(_fixedJoystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _fixedJoystick.Vertical * _moveSpeed);
            Move(direction);
            Look(direction);
        }
        else
        {
            _rigidbody.velocity = Vector3.zero;
        }
    }

    private void Move(Vector3 direction)
    {
        _rigidbody.velocity = direction;
    }

    private void Look(Vector3 direction)
    {
        float scaledRotationSpeed = _rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction),scaledRotationSpeed);
    }
}
