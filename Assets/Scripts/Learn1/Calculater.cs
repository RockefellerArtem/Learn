using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculater : MonoBehaviour
{
    //Задача:
    // Взять значение со скрипта TestName
    // Затем нам нужно его изменить 
    // и в конце снова вернуть его
    //каждый этап выводить в консоль

    private TestNamer _testNamer;
    [SerializeField] private GameObject _contentTestNamer;

    public void Start()
    {
        _testNamer = _contentTestNamer.GetComponent<TestNamer>();

        int test = _testNamer.Count;
        Debug.Log("Начальное число " + test);

        _testNamer.Count = 9;
        Debug.Log("Измененное значение " + _testNamer.Count);

        _testNamer.Count = test;
        Debug.Log("Опять начальное значение" + _testNamer.Count);
    }
}
