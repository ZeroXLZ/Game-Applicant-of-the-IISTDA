using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateTr : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F) && other.gameObject.tag == "Player")
        {
            GameObject.Find("EnterExitTr").SetActive(false);
            GameObject.Find("EnterTr2").transform.GetComponent<Collider>().enabled = true;
            GameObject.Find("ExitTr").transform.GetComponent<Collider>().enabled = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Canvas/Tasks").GetComponent<Text>().text = "- Заполните бланк заявления";
        }
    }
}
