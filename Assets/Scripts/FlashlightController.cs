using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioPlayer;

    public Light flashlight;

    public static float currentCharge = 1000;

    public static float maxCharge = 1000;

    public float dischargeAmount = 6;

    public float showCharge = currentCharge;

    public float intensity = 2.0f;

    public float range = 100;

    public static bool isOn = false;

    float lastTick = 0.0f;

    private float time = 0.0f;

    public float tickDischargeTime = 0.05f;

    void Start()
    {
        flashlight = GetComponent<Light>();
        flashlight.intensity = intensity;
        flashlight.range = range;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCharge > 0)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (isOn)
                {
                    audioPlayer.Play();
                    isOn = false;
                }
                else
                {
                    audioPlayer.Play();

                    isOn = true;
                    currentCharge -= 50;
                }
            }
        }
        else
        {
            isOn = false;
        }
        time += Time.deltaTime;
        if (isOn)
        {
            flashlight.intensity = intensity;
            startDischarge();
        }
        else
        {
            flashlight.intensity = 0;
        }
    }

    void startDischarge()
    {
        if (isOn)
        {
            if ((time - lastTick) > tickDischargeTime)
            {
                lastTick = time;

                currentCharge -= 1;
                currentCharge = currentCharge <= 0 ? 0 : currentCharge;
            }
        }
    }
}
