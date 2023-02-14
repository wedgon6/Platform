using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAboutAuthor : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public void SpavnPanel()
    {
        _panel.SetActive(true);
    }

    public void ExitPanel()
    {
        _panel.SetActive(false);
    }
}
