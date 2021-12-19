using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathLogicCalculater : MonoBehaviour
{
    private Logger _logger;

    [SerializeField] private int _number1;
    [SerializeField] private int _number2;


    private void Awake()
    {
        _logger = GetComponent<Logger>();

        int _num = _number1 + _number2;

        _logger.Log(_num.ToString());
    }
}
