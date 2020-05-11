using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Control : MonoBehaviour
{
    // Start is called before the first frame update

    public void reslevl()
    {
       // Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
        //Time.timeScale = 1;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
