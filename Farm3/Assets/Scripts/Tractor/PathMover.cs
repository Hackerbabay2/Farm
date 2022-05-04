using PathCreation;
using UnityEngine;

public class PathMover : MonoBehaviour
{
    [SerializeField] private PathCreator _pathCreator;
    [SerializeField] private EndOfPathInstruction _endOfPathInstruction = EndOfPathInstruction.Stop;
    [SerializeField] private float _speed = 7;

    private float _distanceTravelled;

    public void SetSpeed(float speed)
    {
        if (_pathCreator != null)
        {
            _speed = speed;
        }
    }

    private void OnEnable()
    {
        if (_pathCreator != null)
        {
            _pathCreator.pathUpdated += OnPathChanged;
        }
    }

    private void OnDisable()
    {
        _pathCreator.pathUpdated -= OnPathChanged;
    }

    private void Update()
    {
        if (_pathCreator != null)
        {
            _distanceTravelled += _speed * Time.deltaTime;
            transform.position = _pathCreator.path.GetPointAtDistance(_distanceTravelled, _endOfPathInstruction);
            Quaternion rotation = _pathCreator.path.GetRotationAtDistance(_distanceTravelled, _endOfPathInstruction);
            rotation.x = 0;
            rotation.z = 0;
            transform.rotation = rotation;
        }
    }

    private void OnPathChanged()
    {
        _distanceTravelled = _pathCreator.path.GetClosestDistanceAlongPath(transform.position);
    }
}
