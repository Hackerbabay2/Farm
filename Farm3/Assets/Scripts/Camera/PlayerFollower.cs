using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;
    [SerializeField] private float _ident = 50;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x,transform.position.y,_player.position.z - _ident),_speed * Time.deltaTime);
    }
}
