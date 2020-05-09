using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_object : MonoBehaviour
{
    public GameObject[] obj; // Объявление массива обьектов
    public float[] positions;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(
                 obj[Random.Range(0, obj.Length)],
                 new Vector3(Random.Range(-23, 23), 0, Random.Range(-23, 23)),
                 Quaternion.Euler(new Vector3(0, -180, 0))
                 );
            yield return new WaitForSeconds(2f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
