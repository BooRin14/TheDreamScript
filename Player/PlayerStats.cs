using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;
    [SerializeField]
    private GameObject
        deathChunkParticle,
        deathBloodParticle;

    [SerializeField]
    private GameObject gameOverUI;

    private float currentHealth;

    [SerializeField]
    private Slider healthSlider;

    public static event Action OnPlayerDeath;

    private void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
        healthSlider.interactable = false; // Tambahkan baris ini untuk menonaktifkan interaktivitas pengguna pada Slider
        gameOverUI.SetActive(false);
    }

    public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0.0f)
        {
            Die();
            OnPlayerDeath?.Invoke();
        }
    }

    private void Die()
    {
        Instantiate(deathChunkParticle, transform.position, deathChunkParticle.transform.rotation);
        Instantiate(deathBloodParticle, transform.position, deathBloodParticle.transform.rotation);
        healthSlider.value = healthSlider.maxValue;
        Destroy(gameObject);
        gameOverUI.SetActive(true);
    }
}