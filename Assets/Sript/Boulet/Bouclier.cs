using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Bouclier : MonoBehaviour {

    public int currentHealth = 1;
    public int maxHealth = 30;
    public bool isDead = false;
    public int nombreDeVie = 3;
    public int currentNombreDeVie;
    public float currentTime;
    public float tempsFinal;
    

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        currentTime += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bonus"))
        {
            Health(1);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("atome"))
        {
            TakeDamage(9);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("arrive"))
        {
            
            currentTime = tempsFinal;
            Destroy(gameObject);
            Debug.Log("Gagné");
            Debug.Log("tu as mis " + tempsFinal);
            Time.timeScale = 0f;
        }
    }


    void Health(int healAmount)
    {
        Debug.Log("Healing " + healAmount);
        int healthResult = currentHealth;
        healthResult = currentHealth + healAmount;
        currentHealth = healthResult;
        currentHealth = currentHealth + healAmount;
        if (healthResult > maxHealth) //Clamp => min < valeur > max créer un interval
        {
            currentHealth = maxHealth;
            Debug.Log("Heal complete " + currentHealth);
        }
    }
    
    void TakeDamage(int damageAmmount)
    {
        Debug.Log("Taking damage " + damageAmmount);
        int healthResult;
        healthResult = currentHealth - (damageAmmount);
        currentHealth = healthResult;
        if (healthResult <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
            isDead = true;
            Debug.Log("I'm Dead");
           

        }
        Debug.Log("NewLife" + currentHealth);

    }
    /*
    public void ToggleVictoryMenu()
    {
        VictoryMenu.SetActive(!VictoryMenu.activeSelf);
    }
    */
    /*
        public static implicit operator Bouclier(bool v)
        {
            throw new NotImplementedException();
        }
        */
}
