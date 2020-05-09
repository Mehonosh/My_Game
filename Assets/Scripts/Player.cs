using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coin; // Очки
    public Text txtcoin;
    private void OnCollisionStay(Collision collision)
    {
        // машинка уничтожается при столкновении
        if (collision.gameObject.CompareTag("Box")) // При тегге Box Добавляется 1 очко
        {
            coin = coin + 1;
        }
        // машинка уничтожается при столкновении
        if (collision.gameObject.CompareTag("q")) // При тегге Player Добавляется 2 очка
        {
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
    }
}
