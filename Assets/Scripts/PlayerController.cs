using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Battery"))
        {
            FlashlightController.currentCharge += Random.Range(40, 100);
            Destroy(c.gameObject);
        }
        if (c.gameObject.CompareTag("Aid"))
        {
            PlayerStats.currentHealth += Random.Range(40, 100);
            Destroy(c.gameObject);
        }
        if (c.gameObject.CompareTag("Crystal"))
        {
            PlayerStats.crystals += 1;
            Destroy(c.gameObject);
        }
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
