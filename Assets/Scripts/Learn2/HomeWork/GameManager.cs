using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Image _image;

    [SerializeField] private Color[] _colors;

    public void Red()
    {
        _image.color = _colors[0];
    }

    public void Yellow()
    {
        _image.color = _colors[2];
    }

    public void Green()
    {
        _image.color = _colors[1];
    }
}
