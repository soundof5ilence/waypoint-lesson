using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WallHealth : MonoBehaviour
{
    public float maxHealth;
    public float health;
    bool isDead = false;
    float timeBeforeDead = 1f;

    public float maxInvinsibilityTime;
    public float invinsibilityTime;
    float respawnTime = 5f;

    public GameObject[] healthImage;
    public Sprite[] healthSprites;
    Animator animator;

    // Use this for initialization
    void Start()
    {
        health = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        invinsibilityTime -= Time.deltaTime;
        if (health == maxHealth)
        {
           

        }
        
        else if (health == 0f)
        {
            
            Death();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Death();
        }
        if (isDead)
        {
            timeBeforeDead -= Time.deltaTime;
            animator.SetBool("dead", true);
            if (timeBeforeDead <= 0)
            {
                SceneManager.LoadScene(sceneName: "MainMenu");
            }
        }

        if (invinsibilityTime <= 0)
        {
            CancelInvoke("RepeatThingy");
        }



    }


    // below this is the script that makes the enemy's and surrounding dangers damage you.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("object: " + collision.gameObject.name + " tag: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Enemy")
        {
            // names of the collision must change to the enemy name!! it matters cuz this checks for how much damage you get
            if (collision.gameObject.name == "soldier")
            {
                getDamage(1);
                Debug.Log("ouch");
            }
            else if (collision.gameObject.name == "something else")
            {
                getDamage(0.5f);
            }
          



        }
    }


    void getDamage(float DamageCount)
    {

        if (invinsibilityTime <= 0)
        {
            health -= DamageCount;
            invinsibilityTime = maxInvinsibilityTime;
            Debug.Log("invis");

            InvokeRepeating("RepeatThingy", 0f, 0.5f);

        }
    }


    void Death()
    {
        isDead = true;
    }

}
