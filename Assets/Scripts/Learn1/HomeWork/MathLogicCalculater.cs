using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathLogicCalculater : MonoBehaviour
{
    [SerializeField] private GameObject _logger;
    private Logger _debugLog;

    [SerializeField] private int _number1;
    [SerializeField] private int _number2;

    private int _num;

    private void Awake()
    {
        _debugLog = _logger.GetComponent<Logger>();

        _num = _number1 + _number2;

        _debugLog.Log(_num.ToString());
    }
}
