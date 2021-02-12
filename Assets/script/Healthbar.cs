using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        //slider = GetComponent<Slider>();
      
    }

    public void UpdateHealthbar(float health)
    {
        slider.value = health;
    }
}
