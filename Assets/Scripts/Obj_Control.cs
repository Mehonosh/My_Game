using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_Control : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        // машинка уничтожается при столкновении
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Destroy(gameObject); //уничтожается объект
            // включается камера, где написано что объект проиграл
            //Time.timeScale = 0;
            //isPaused = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
