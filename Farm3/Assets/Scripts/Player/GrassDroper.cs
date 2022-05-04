using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GrassDroper : MonoBehaviour
{
    [SerializeField] private Transform _pool;
    [SerializeField] private GameObject _grass;
    [SerializeField] private int _count = 15;
    [SerializeField] private Transform _departurePoint;

    private List<GameObject> _grassList = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < _count; i++)
        {
            GameObject grass = Instantiate(_grass,_pool);
            _grassList.Add(grass);
            grass.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Wheat wheat))
        {
            Drop();
            wheat.gameObject.SetActive(false);
        }
    }

    public void Drop()
    {
        GameObject dropgrass = _grassList.FirstOrDefault(g => g.activeSelf == false);
        dropgrass.SetActive(true);
        dropgrass.transform.position = _departurePoint.position;
    }
}
