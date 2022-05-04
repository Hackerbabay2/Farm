using UnityEngine;

public class InputChecker : MonoBehaviour
{
    [SerializeField] private PathMover _pathMover;
    [SerializeField] private SetTargetIsFull _setTargetIsFull;
    [SerializeField] private float _speed;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _pathMover.SetSpeed(_speed);
            _setTargetIsFull.enabled = true;
            Destroy(gameObject);
        }
    }
}
