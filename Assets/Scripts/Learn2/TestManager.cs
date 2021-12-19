using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestManager : MonoBehaviour
{
    [SerializeField] private TestObject[] ids;

    public void Log(TestObject index)
    {
        index.Log();
    }
}
