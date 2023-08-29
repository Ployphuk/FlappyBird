using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private float currentHealth;

    [SerializeField] private Text healthText; // Drag your UI Text element here in the Inspector
    public GameObject playButton;
    public GameObject gameOver;
    
    private void Awake()
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
            Debug.Log("Gameover");
        }
    }

    private void UpdateHealthDisplay()
    {
        healthText.text = "Health: " + currentHealth.ToString(); // Update UI Text with current health
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Obstacle"){
            TakeDamage(2);
        }else if(collision.tag == "Ground"){
            TakeDamage(10);
        }
    }
    
}
