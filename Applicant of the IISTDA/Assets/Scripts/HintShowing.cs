using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintShowing : MonoBehaviour
{
    public string text;

    void ShowHint()
    {
        GameObject.Find("Canvas/Hint").GetComponent<Text>().text = text;
    }
    void CloseHint()
    {
        GameObject.Find("Canvas/Hint").GetComponent<Text>().text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ShowHint();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CloseHint();
        }
    }
}
