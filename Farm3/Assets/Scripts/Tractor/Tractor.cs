using UnityEngine;

public class Tractor : MonoBehaviour
{
    [SerializeField] private SetFinishTarget _setFinishTarget;
    [SerializeField] private GrassLoader _grassLoader;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Finish finish))
        {
            _setFinishTarget.enabled = true;
            StartCoroutine(_grassLoader.Load());
        }
    }
}
