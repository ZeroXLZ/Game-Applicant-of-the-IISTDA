using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameMenuLogic : MonoBehaviour
{
    public GameObject menu;
    public GameObject outp;
    public GameObject sett;
    void Start()
    {
        menu.SetActive(false);
        outp.SetActive(false);
        sett.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            OnClickMenu();
    }

    public void OnClickMenu()
    {
        menu.SetActive(true);
        GameObject.Find("Canvas/Background").GetComponent<Image>().enabled = true;
        Time.timeScale = 0;
    }

    public void OnContinue()
    {
        menu.SetActive(false);
        GameObject.Find("Canvas/Background").GetComponent<Image>().enabled = false;
        Time.timeScale = 1;
    }

    public void OnSettings()
    {
        menu.SetActive(false);
        sett.SetActive(true);
    }

    public void OnExitSettings()
    {
        menu.SetActive(true);
        sett.SetActive(false);
    }

    public void OnAskExit()
    {
        menu.SetActive(false);
        outp.SetActive(true);
    }

    public void OnExit()
    {
        Time.timeScale = 1;
        Effects.FadeScreen(Color.black, 0, 1, 3, () => SceneManager.LoadScene(0));
    }

    public void OnNoExit()
    {
        menu.SetActive(true);
        outp.SetActive(false);
    }
}
