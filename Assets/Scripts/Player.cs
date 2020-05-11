using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text timetxt; // Обозначаем поле текста
    public Slider timeSlider; // Обозначаем слайдер

    public GameObject canvas_Game_over;
    public GameObject canvas_main;

    public int timeleft = 60; //Обозначаем максимальное знаачение времени
    private float gameTime;

    public int coin; // Очки
    public Text txtcoin;
    public Text txtscore;
    private void OnCollisionStay(Collision collision)
    {
        // машинка уничтожается при столкновении
        if (collision.gameObject.CompareTag("Box")) // При тегге Box Добавляется 1 очко
        {
            timeleft = timeleft + 1;
            coin = coin + 1;
        }
        // машинка уничтожается при столкновении
        if (collision.gameObject.CompareTag("q")) // При тегге Player Добавляется 2 очка
        {
            timeleft = timeleft + 2;
            coin = coin + 2;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtcoin.text = "" + coin;
        txtscore.text = "" + coin;

        timeSlider.value = timeleft;
        timetxt.text = "Осталось " + timeleft + " сек.";
        gameTime += 1 * Time.deltaTime;
        if (gameTime >= 1)
        {
            timeleft -= 1;
            gameTime = 0;
        }
        if (timeleft == 0)
        {
            
            canvas_Game_over.SetActive(true);
            canvas_main.SetActive(false);
            Destroy(gameObject);
            //  Time.timeScale = 0;
        }
    }
    public void reload()
    {
        Time.timeScale = 1;
        canvas_Game_over.SetActive(false);
        canvas_main.SetActive(true);
    }
}

