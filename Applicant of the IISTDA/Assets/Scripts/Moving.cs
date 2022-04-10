using UnityEngine;
using System.Collections;
public class Moving : MonoBehaviour
{
    private GameObject player;
    public int speed = 12;
    private int speedNormal;
    private Animator anima;
    float x_rev;
    float x;

    void Start()
    {
        player = (GameObject)this.gameObject;
        anima = GetComponent<Animator>();
        x_rev = player.transform.localScale.x * -1;
        x = x_rev * -1;
        speedNormal = speed;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speed = 17;
        }
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
            
            transform.localScale = new Vector3(x_rev, player.transform.localScale.y * 1, player.transform.localScale.z * 1);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anima.SetBool("isRun", true);
            player.transform.position += player.transform.right * speed * Time.deltaTime;
            transform.localScale = new Vector3(x, player.transform.localScale.y * 1, player.transform.localScale.z * 1);
        }
        speed = speedNormal;
    }
}