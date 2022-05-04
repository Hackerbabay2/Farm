using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class GrassFiller : MonoBehaviour
{
    [SerializeField] private GameObject _grassBlock;
    [SerializeField] private Transform _container;
    [SerializeField] private PathCompleter _pathCompleter;

    private Animator _animator;
    private float _maxX, _maxZ, _maxHeight;
    private float _currentX = 0, _currentZ = 0, _currentHeight = 0;
    private float _scale;
    private const string IsFull = "IsFull";
    private float _sizeContrainer;

    public event UnityAction<float, float> IsAdded;
    public float SizeContainer => _sizeContrainer;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _scale = 0.1f;
        _maxX = _scale * 3;
        _maxZ = _scale * 4;
        _maxHeight = _scale * 12;
        _sizeContrainer = (_maxX * _maxZ * _maxHeight) * 1000;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Grass grass))
        {
            AddBlock();
            grass.gameObject.SetActive(false);
        }
    }

    private void AddBlock()
    {
        if (_currentX >= _maxX)
        {
            _currentX = 0;

            if (_currentZ < _maxZ-_scale)
            {
                _currentZ += _scale;
            }
            else
            {
                _currentHeight += _scale;
                _currentZ = 0;
            }

        }

        if (_currentHeight < _maxHeight)
        {
            GameObject grassBlock = Instantiate(_grassBlock, _container);
            grassBlock.transform.localPosition = new Vector3(_currentX,_currentHeight,_currentZ);
            _currentX += _scale;
            IsAdded?.Invoke(_container.childCount,SizeContainer);
        }
        else
        {
            _animator.Play(IsFull);

            if (_pathCompleter.enabled == true)
            {
                _pathCompleter.ShowText();
            }
        }
    }
}
