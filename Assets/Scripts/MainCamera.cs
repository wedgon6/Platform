using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[RequireComponent(typeof(AudioSource))]
public class MainCamera : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private AudioSource _audio;
    private Coroutine _coroutine;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        _coroutine = StartCoroutine(HellVoise());
    }

    private void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = _player.position.x;
        temp.y = _player.position.y;

        transform.position = temp;
    }

    private IEnumerator HellVoise()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            _audio.Play();
            yield return new WaitForSeconds(20);
        }
    }
}
