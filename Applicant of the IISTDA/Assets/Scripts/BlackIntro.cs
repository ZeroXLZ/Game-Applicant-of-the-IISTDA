using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackIntro : MonoBehaviour
{
    public AudioClip[] clips;
    void Start()
    {
        StartCoroutine(MusicPlay());
    }
    IEnumerator MusicPlay()
    {
        for (int i = 0; i < clips.Length; i++)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = clips[i];
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
        }
        Effects.FadeScreen(Color.black, 0, 1, 3, () => SceneManager.LoadScene(3));
    }
}