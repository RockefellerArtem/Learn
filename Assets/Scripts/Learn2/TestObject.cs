using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    [SerializeField] private string Message;
    private bool _isActive = false;
    public void Log()
    {
        _isActive = !_isActive;
        if (_isActive)
        {
            enabled = true;
        }
        else
        {
            Destroy(gameObject);
        }
        
        Debug.Log(Message);
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

/*    private void OnDestroy()
    {
        Debug.Log("Объект удален!!!!");
    }

    private void OnEnable()
    {
        Debug.Log("Объект включен!");
    }

    private void OnDisable()
    {
        Debug.Log("Объект выключен!");
    }*/

}
