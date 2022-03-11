using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _gameOverMenu;
    private void Update()
    {
        if (MoneyText._coin == 5)
        {
            _gameOverMenu.SetActive(true);
            MoneyText._coin = 0;
        }
    }

    public void Restart()
    {
        _gameOverMenu.SetActive(false);
        MoneyText._coin = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
