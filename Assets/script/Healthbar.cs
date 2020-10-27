using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = 100;
        slider.value = 100;
    }



    public void SetMaxHealth(int health)
    {
       
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;

    }
}
