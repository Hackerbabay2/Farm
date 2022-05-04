using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassLoader : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] private float _duration;
    [SerializeField] private GameObject _finishUI;

    private List<GameObject> _grass = new List<GameObject>();

    public IEnumerator Load()
    {
        _finishUI.SetActive(true);

        if (_container.childCount > 0)
        {
            WaitForSeconds wait = new WaitForSeconds(_duration);
            FillGrassList();


            for (int i = 0; i < _grass.Count; i++)
            {
                Loader loader = _grass[i].GetComponent<Loader>();
                loader.StartCoroutine(loader.Load());
                yield return wait;
            }
        }
    }

    private void FillGrassList()
    {
        for (int i = 0; i < _container.childCount; i++)
        {
            _grass.Add(_container.GetChild(i).gameObject);
        }
        _grass.Reverse();
    }
}
