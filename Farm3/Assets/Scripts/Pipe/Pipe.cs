using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private Transform _pipeTarget;

    private void Update()
    {
        transform.position = _pipeTarget.position;
    }
}
