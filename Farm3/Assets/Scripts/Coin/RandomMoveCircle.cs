using UnityEngine;

public class RandomMoveCircle : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _speed;
    [SerializeField] private MoveReward _moveReward;
    private Vector2 _direction;

    private void Start()
    {
        _direction = Random.insideUnitCircle * _radius;
    }

    private void Update()
    {
        transform.localPosition = Vector2.MoveTowards(transform.localPosition, _direction, _speed * Time.deltaTime);

        if (transform.localPosition.x == _direction.x && transform.localPosition.y == _direction.y)
        {
            _moveReward.enabled = true;
            enabled = false;
        }
    }
}
