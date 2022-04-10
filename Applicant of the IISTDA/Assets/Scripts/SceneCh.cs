using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCh : MonoBehaviour
{
    public string SceneName;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}