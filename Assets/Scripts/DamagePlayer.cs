using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public static int hits = 0;

    void Start()
    {
    }

    public void hit()
    {
        if (hits > 1)
        {
            PlayerStats.currentHealth -= Random.Range(20, 50);
        }
        hits += 1;
    }
}
