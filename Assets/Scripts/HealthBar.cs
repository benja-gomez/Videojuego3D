using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Image healthBar;

    public float waitTime = 30.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float adaptFill = PlayerStats.currentHealth / PlayerStats.maxHealth;
        if (adaptFill > 1000)
        {
            healthBar.fillAmount = 1000;
        }
        else
        {
            healthBar.fillAmount = adaptFill;
        }
        healthBar.fillAmount = adaptFill;
    }
}
