
using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Virus : MonoBehaviour
{

    public float startSpeed = 10f;
    
    [HideInInspector]
    public float speed;

    public float health = 100;

    public int worth = 50;

    private void Start()
    {
        speed = startSpeed;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }
    void Die()
    {
        if (PlayerStats.Money <= 10000)
        {
            PlayerStats.Money += worth;
        }
        Destroy(gameObject);
    }
    
}
