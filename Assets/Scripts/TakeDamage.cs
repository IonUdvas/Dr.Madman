using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start(){
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Damage(20);
        }
    }

    void Damage(int damage){
        currentHealth -= 20;
        healthBar.SetHealth(currentHealth);
    }
}
