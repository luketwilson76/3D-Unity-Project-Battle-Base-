using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    [SerializeField]
    string strTag;

    public float health;
    public float maxHealth;
    public bool damage = true;
    public GameObject healthBarUI;
    public Slider slider;
    
    void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    void Update()
    {
        slider.value = CalculateHealth();

        if(health < maxHealth)
        { 
            healthBarUI.SetActive(true);
        }

        if(health<=0)
        {
            Destroy(gameObject);
        }
        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }

    IEnumerator OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == strTag && damage == true)
        {
            health = health - 10;
            damage = false;
            yield return new WaitForSeconds(1);
            damage = true;
        }
    }
}
