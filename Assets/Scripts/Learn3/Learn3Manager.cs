using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn3Manager : MonoBehaviour
{
    [SerializeField] private int[] _numbersMassive;

    [SerializeField] private List<GameObject> _gameObjects;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _content;

    private void Start()
    {
        _numbersMassive = new int[2] { 30, 222 };


        /*        var newMasssive = new int[3] { _numbersMassive[0], _numbersMassive[1], 56 };
                _numbersMassive = newMasssive;*/

        /*        var newList = new List<int>(3) { _numbersList[0], _numbersList[1], 53 };
                _numbersList = newList;*/

        /*        switch (_numbersList[1])
                {
                    case 9:
                        Debug.Log("Носки!");
                        break;
                    case 4:
                        Debug.Log("Кот!");
                        break;
                }*/

/*        for (int i = 0; i < 10; i++)
        {
            var temp = Instantiate(_prefab, _content);
            _gameObjects.Add(temp);
        }

        var message = _numbersMassive[1] == 222 ? "ДА" : "НЕТ"; // переменна = условие ? true : false
        Debug.Log(message);
        if (message == "ДА")
        {
            Debug.Log("GOOD!");
        }*/
    }

    private void Update()
    {
/*        if (Input.GetKeyDown(KeyCode.F))
        {
            _gameObjects[5].SetActive(false);
        }*/
/*        if (Input.GetKeyDown(KeyCode.D))
        {
            _numbersList.RemoveAt(1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _numbersList.Remove(5);
        }*/
    }
}
