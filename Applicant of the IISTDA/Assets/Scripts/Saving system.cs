using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test1 : MonoBehaviour
{
    public static test1 Instance;
    private static string sceneName;
    private static string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\saves\scene.sistu";

    // Start is called before the first frame update
    void Start()
    {
        GameState state = new GameState();
        BinaryFormatter formatter = new BinaryFormatter();

        try
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                state = (GameState)formatter.Deserialize(stream);
            }
        }
        catch (Exception ex)
        {
            state.sceneN = "Hall";
        }
        SceneManager.LoadScene(state.sceneN);
        Vector3 vec = new Vector3(state.position[0], state.position[1], state.position[2]);
    }

    private void Awake()
    {
        if (!Instance)
        {
            SceneManager.activeSceneChanged += ChangedActiveScene;
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void ChangedActiveScene(Scene arg0, Scene arg1)
    {
        sceneName = arg1.name;
    }

    void OnApplicationQuit()
    {
        GameState state = new GameState()
        {
            sceneN = sceneName,
            position = new float[3] { GameObject.FindWithTag("Player").transform.position.x, GameObject.FindWithTag("Player").transform.position.y, GameObject.FindWithTag("Player").transform.position.z }
        };
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            formatter.Serialize(stream, state);
        }
    }
}