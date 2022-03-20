using UnityEngine;
using System.Collections;
public class Moving : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;
    private Animator anima;

    void Start()
    {
        player = (GameObject)this.gameObject;
        anima = GetComponent<Animator>();
    }
    void Update()
    {
        anima.SetBool("isRun", false);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anima.SetBool("isRun", true);
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anima.SetBool("isRun", true);
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anima.SetBool("isRun", true);
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anima.SetBool("isRun", true);
            player.transform.position += player.transform.right * speed * Time.deltaTime;
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}