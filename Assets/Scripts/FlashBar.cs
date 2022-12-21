using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashBar : MonoBehaviour
{
    public Image flashBar;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float adaptFill =
            FlashlightController.currentCharge / FlashlightController.maxCharge;
        if (adaptFill > 1000)
        {
            flashBar.fillAmount = 1000;
        }
        else
        {
            flashBar.fillAmount = adaptFill;
        }
    }
}
