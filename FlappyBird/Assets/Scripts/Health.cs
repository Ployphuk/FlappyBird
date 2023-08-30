using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth{get; private set;}

    [SerializeField] private Text healthText;
    private bool dead;
    
    private void Start()
    {
        currentHealth = startingHealth;
        UpdateHealthDisplay();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        UpdateHealthDisplay();

        if (currentHealth <= 0)
        {   
           FindObjectOfType<GameManager>().GameOver();
           currentHealth = 3;
           healthText.text = "Health: " + currentHealth.ToString();
        }
    }

    public void UpdateHealthDisplay()
    {
        healthText.text = "Health: " + currentHealth.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Obstacle"){
            TakeDamage(1);
        }else if(collision.tag == "Ground"){
            TakeDamage(3);
        }
    }
    
    
}
