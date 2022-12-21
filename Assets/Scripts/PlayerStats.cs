using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static float currentHealth = 1;

    public static float maxHealth = 1000;

    public static bool ganaste = false;

    public static int crystals = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Initiate.Fade("Level_02", Color.black, 2f);
        }
        if (crystals >= 8)
        {
            ganaste = true;
            Initiate.Fade("Level_02", Color.black, 2f);
        }
    }


}
