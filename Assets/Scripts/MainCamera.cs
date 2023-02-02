using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private void Start()
    {
        //_player = GetComponent<Player>();
    }

    private void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = _player.position.x;
        temp.y = _player.position.y;

        transform.position = temp;
    }
}
