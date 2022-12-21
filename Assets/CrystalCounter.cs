using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public Text counter;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = PlayerStats.crystals.ToString();
    }
}
