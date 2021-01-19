using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float Extend = 1f;

    IEnumerator WaitingonLoad()
    {
        yield return new WaitForSeconds(Extend);
        SceneManager.LoadScene("Over");
    }
    IEnumerator WaitingonWin()
    {
        yield return new WaitForSeconds(Extend);
        SceneManager.LoadScene("Winner");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Car_Game 1");
        FindObjectOfType<GameSession>().ResetGame();
    }
    public void LoadGameOver()
    {
        StartCoroutine(WaitingonLoad());
    }
    public static void LoadWinner()
    {
        SceneManager.LoadScene("Winner");
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
