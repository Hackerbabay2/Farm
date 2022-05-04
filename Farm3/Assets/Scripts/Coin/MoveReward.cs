using UnityEngine;

public class MoveReward : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;

    private void OnEnable()
    {
        transform.SetParent(_target);
    }

    private void Update()
    {
        if (_target != null)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition,_target.localPosition,_speed * Time.deltaTime);
        }
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
