using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            Effects.FadeScreen(Color.black, 0, 1, 1, () => SceneManager.LoadScene("MainMenu"));
        }
    }
}
