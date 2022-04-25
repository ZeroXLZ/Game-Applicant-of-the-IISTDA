using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegEvent : MonoBehaviour
{
    public GameObject regWindow;
    public AudioClip[] clips;
    void Start()
    {
        regWindow.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F) && other.gameObject.tag == "Player")
        {
            OnClick();
        }
    }

    public void OnClick()
    {
        GameObject.Find("Canvas/Hint").GetComponent<Text>().text = "";
        regWindow.SetActive(true);
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = clips[0];
        audio.loop = true;
        audio.Play();
        Time.timeScale = 0;
    }

    public void OnReg()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = clips[1];
        audio.loop = false;
        audio.Play();
        regWindow.SetActive(false);
        Time.timeScale = 1;
        GameObject.Find("Canvas/Task").GetComponent<Text>().text = "Задание выполнено!";
        GameObject.Find("Canvas/Tasks").GetComponent<Text>().text = "- Идите домой";
        GameObject.Find("Canvas/Hint").GetComponent<Text>().text = "Пора уходить";
        StartCoroutine(HintCoroutine());
    }

    IEnumerator HintCoroutine()
    {
        yield return new WaitForSeconds(5);
        GameObject.Find("Canvas/Hint").GetComponent<Text>().text = "";
    }
}
