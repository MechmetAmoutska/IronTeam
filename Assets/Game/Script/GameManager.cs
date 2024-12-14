using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameUI_Manager gameUI_Manager;
    public Character playerCharacter;
    private bool gameIsOver;

    private void Awake()
    {
        playerCharacter = GameObject.FindWithTag("Player").GetComponent<Character>();
    }

    private void GameOver()
    {
        Debug.Log("GAME OVER");
    }

    public void  GameIsFinished()
    {
        Debug.Log("GAME IS FINISHED");
    }

    void Update()
    {
        if (gameIsOver)
            return;

        if (Input.GetKeyDown(KeyCode.Escape))
            gameUI_Manager.TogglePauseUI();

        if (playerCharacter.CurrentState == Character.CharacterState.Dead)
        {
            gameIsOver = true;
            GameOver();
        }
    }

    public void ReturnToTheMainMenu()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}