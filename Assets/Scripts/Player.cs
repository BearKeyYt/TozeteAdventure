using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour { 
    public int maxHealth = 100;
    public int currentHealth;
    public static float health = 100;
    public Health BarhealthBar;

    // Start is called before the first frame update
    void Start(){
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    
    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(20);
        }
    }
    void TakeDamage(int damage){
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0){
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag.Equals("Enemy")){
            TakeDamage(20);
        }
    }
}