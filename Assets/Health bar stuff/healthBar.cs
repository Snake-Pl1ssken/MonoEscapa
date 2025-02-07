using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsciousnessBar : MonoBehaviour
{
    public Slider ConsciousnessSlider;
    public Slider easeConsciousnessSlider;
    public float maxHealth = 100f;
    public float health;
    private float lerpSpeed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (ConsciousnessSlider.value != health)
        {
            ConsciousnessSlider.value = health;
        }

        if (Input.GetKeyDown(KeyCode.J)) //test Health bar
        {
            takeDamage(10);
        }

        if (ConsciousnessSlider.value != easeConsciousnessSlider.value)
        {
            easeConsciousnessSlider.value = Mathf.Lerp(easeConsciousnessSlider.value, health, lerpSpeed);
        }
    }

    void takeDamage(float v)
    {
        health -= v;
    }
}
