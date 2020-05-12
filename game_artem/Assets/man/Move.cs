using UnityEngine;
using System.Collections;
public class move : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;
    public Animator anim;

    void Start()
    {
        player = (GameObject)this.gameObject;
        anim =  GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
            anim.enabled = true;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
        }
    }
}