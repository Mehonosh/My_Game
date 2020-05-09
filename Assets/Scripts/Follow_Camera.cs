using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Camera : MonoBehaviour
{
    public GameObject player; // Добавить игрока 
    private Vector3 offset; // Переменная перемещения

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
