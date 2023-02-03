using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreator : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private Transform _point;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_point.childCount];

        for (int i = 0; i < _point.childCount; i++)
        {
            _points[i] = _point.GetChild(i);
        }

        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {

        for (int i = 0; i < _points.Length; i++)
        {
            Instantiate(_coin, _points[i].position, Quaternion.identity);

            yield return new WaitForSeconds(0);
        }
    }
}
