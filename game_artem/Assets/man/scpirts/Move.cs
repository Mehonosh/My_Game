using UnityEngine;
using System.Collections;
public class Move : MonoBehaviour
{
    public int speed = 5;
    public Animator anim;

    void Start()
    {
        anim =  GetComponent<Animator>();
    }
    void Update()
    {
        //движение вперед + включение анимации
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
            //anim.enabled = true;
            anim.enabled = !anim.enabled;
        }
        //движение назад + включение анимации
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            anim.enabled = !anim.enabled;
        }
    }
}