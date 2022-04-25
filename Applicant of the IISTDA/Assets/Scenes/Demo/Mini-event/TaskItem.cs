using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskItem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private GameObject check;
    public void SetText(string value)
    {
        text.text = value;
    }

    public void SetCheck(bool value)
    {
        check.SetActive(value);
    }
}
