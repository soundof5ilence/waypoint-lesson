using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    public Healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        
        currentHealth = maxHealth;
        healthbar.UpdateHealthbar(GetNormalizedHealth());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
           
        }

      
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.UpdateHealthbar(GetNormalizedHealth());
        if (currentHealth <= 0f)
        {
            print("i am ded");
        }
    }
    public float GetNormalizedHealth()
    {

        return (float)(currentHealth / maxHealth);
    }
}
