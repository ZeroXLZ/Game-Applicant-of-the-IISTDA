using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        Effects.FadeScreen(Color.black, 0, 1, 1, () => SceneManager.LoadScene(1));
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
