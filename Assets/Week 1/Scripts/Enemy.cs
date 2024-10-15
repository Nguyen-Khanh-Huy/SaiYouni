using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // 5 Enemies variables

    //variables 1 
    public float health = 100f;
    //variables 2
    public int attackPower = 10;
    //variables 3 
    public string enemyName = "Goblin";
    //variables 4 
    public bool isAlive = true;
    //variables 5 
    public Vector3 position;

    // 5 Enemies methods

    //Method 1
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    //Method 2
    public void Attack()
    {
        TakeDamage(attackPower);
    }
    //Method 3
    public void Heal(float amount)
    {
        health += amount;
        if (health > 100f)
        {
            health = 100f;
        }
    }
    //Method 4
    public bool IsAlive()
    {
        return health > 0;
    }
    //Method 5
    private void Die()
    {
        Debug.Log("Enemy has died.");
        Destroy(gameObject);
    }
}
