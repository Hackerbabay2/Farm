using UnityEngine;

public class SetFinishTarget : MonoBehaviour
{
    [SerializeField] private PlayerFollower _playerFollower;
    [SerializeField] private SetTargetIsFull _setTargetIsFull;
    [SerializeField] private FixedJoystick _fixedJoystick;
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _lookTarget;
    [SerializeField] private float _speed;

    private void OnEnable()
    {
        _setTargetIsFull.enabled = false;
        _fixedJoystick.gameObject.SetActive(false);
        _playerFollower.enabled = false;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position,_target.position,_speed * Time.deltaTime);
        transform.LookAt(_lookTarget);
    }
}
