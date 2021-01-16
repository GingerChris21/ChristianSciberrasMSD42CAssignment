using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float Extend = 3f;

    IEnumerator WaitingonLoad()
    {
        yield return new WaitForSeconds(Extend);
        SceneManager.LoadScene("Game Over");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Car_Game 1");
    }
    public void LoadGameOver()
    {
        StartCoroutine(WaitingonLoad());
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
