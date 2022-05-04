using UnityEngine;

public class BarnScaler : MonoBehaviour
{
    [SerializeField] private GrassFiller _grassFiller;

    private float _maxAddScale = 1;
    private float _addScale;

    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent(out GrassBlock grassBlock))
        {
            _addScale = (float)_maxAddScale / _grassFiller.SizeContainer;
            transform.localScale += new Vector3(_addScale,_addScale,_addScale);
        }
    }
}
