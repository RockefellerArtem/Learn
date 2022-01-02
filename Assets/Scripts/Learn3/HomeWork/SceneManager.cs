using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private GameObject _right;
    [SerializeField] private GameObject _left;

    [SerializeField] private Text _text;

    [SerializeField] GameObject[] _lights;

    private bool _isActive;
    private bool _isSvetofor;

    public void TrafficLight()
    {
        StartCoroutine(enumerator());
    }

    IEnumerator enumerator()
    {
        
        if(_isSvetofor == true)
        {
            while (true)
            {
                for (int i = 0; i < _lights.Length; i++)
                {
                    _lights[i].SetActive(true);
                    yield return new WaitForSeconds(1f);
                    _lights[i].SetActive(false);
                    yield return new WaitForSeconds(1f);
                }
            }
        }
    }

    public void Power()
    {
        _isActive = !_isActive;
        if (_isActive)
        {
            _right.SetActive(true);

            Debug.Log("Power");
        }
        else
        {
            _right.SetActive(false);

            _text.text = "Включить";
            _left.SetActive(false);
            _isSvetofor = false;

            _text.text = "Включить";
            StopAllCoroutines();
            foreach (GameObject game in _lights)
            {
                game.SetActive(false);
            }
        }
    }

    public void OnOff()
    {
        if(_isActive == true)
        {
            _isSvetofor = !_isSvetofor;
            if(_isSvetofor == true)
            {
                Debug.Log("On");
                _left.SetActive(true);
                _isSvetofor = true;


                _text.text = "Выключить";

                TrafficLight();
            }

            else
            {
                Debug.Log("Off");
                _left.SetActive(false);
                _isSvetofor = false;

                _text.text = "Включить";
                StopAllCoroutines();
                foreach (GameObject game in _lights)
                {
                    game.SetActive(false);
                }
            }
        }

        else
        {
            Debug.Log("Off");
            _left.SetActive(false);
            _isSvetofor = false;

            _text.text = "Включить";
            StopAllCoroutines();
            foreach (GameObject game in _lights)
            {
                game.SetActive(false);
            }
        }
    }
}
