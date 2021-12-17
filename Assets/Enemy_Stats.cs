using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Stats : MonoBehaviour
{
    public float health;
    public int damage;


    void Start()
    {
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    //This is for dealing damage to the enemy and returning whether or not the enemy has died
    float Damage(float dDealt)
    {
        health -= dDealt;
        return health;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerStats>().Damage(damage);
            Debug.Log("Damage");
        }
    }

    #region Getters
    public float Attack()
    {
        return damage;
    }
    public float GetHealth()
    {
        return health;
    }
    #endregion
    #region Setters
    public void SetHealth(int newHealth)
    {
        health = newHealth;
    }
    public void SetDamage(int newDamage)
    {
        damage = newDamage;
    }
    #endregion
}
