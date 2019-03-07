using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 5;
    public int currentHealth;
    public Slider healthSlider;
    public float flashSpeed = 5f;
    public Color flashcolour = new Color(1f, 0f, 0f, 0.1f);
    public Image damageImage;

    bool isDead;
    bool damaged;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (damaged)
        {
            damageImage.color = flashcolour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }

    public void TakeDamage (int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        if(currentHealth  <= 0 && !isDead)
        {
            Death();
        }
    }

    public void Death()
    {
        isDead = true;

        //reset all scores, health, and level variables. 
    }
}
