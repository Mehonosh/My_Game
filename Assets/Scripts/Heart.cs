using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public Slider slider;
    public Text text;
    public GameObject slide;

    public void ShowSliderValue()
    {
        slide = GameObject.FindGameObjectWithTag("Counter");
        text = GetComponent<Text>();
        slider = slide.GetComponent<Slider>();
        text.text = slider.value.ToString();
    }
}
