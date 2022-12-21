using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorphController : MonoBehaviour
{
    Light luz;

    private Vector3 vectorforobject;

    public GameObject notMorphedPrefab;

    public GameObject morphedPrefab;

    public GameObject companion;

    public bool canTransform = false;

    public float minMorphTime = 5;

    public float maxMorphTime = 40;

    // Light flashlight;
    public float transformTime = 10;

    public bool morphed = false;

    public GameObject sophieParticles;

    public GameObject morphParticles;

    float lastTick = 0.0f;

    private float time = 0.0f;

    public float tickUnmorph = 1.5f;

    bool canUnmorph = false;

    void Start()
    {
        morphedPrefab.SetActive(false);
        sophieParticles.SetActive(false);
    }

    private void OnTriggerEnter(Collider c)
    {
        // Debug.Log("Trigger Enter");
        // Comprueba si el objeto que está tocando el foco es una luz
    }

    private void OnTriggerStay(Collider c)
    {
        if (c.gameObject.GetComponent<Light>())
        {
            Light flashlight = c.gameObject.GetComponent<Light>();
            if (flashlight.intensity > 0 && morphed == true)
            {
                time += Time.deltaTime;
                unMorphTime();
                if (canUnmorph)
                {
                    canTransform = false;
                    vectorforobject = morphedPrefab.transform.position;
                    morphedPrefab.SetActive(false);
                    notMorphedPrefab.transform.position = vectorforobject;
                    notMorphedPrefab.SetActive(true);
                    sophieParticles.SetActive(true);

                    morphed = false;
                    DamagePlayer.hits = 0;
                }
            }
            else if (morphed == false && flashlight.intensity <= 0)
            {
                if (morphed == false && canTransform == false)
                {
                    sophieParticles.SetActive(false);
                    transformTime = Random.Range(minMorphTime, maxMorphTime);
                    canTransform = true;
                }
            }
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (!canTransform)
        {
            transformTime = Random.Range(minMorphTime, maxMorphTime);
            canTransform = true;
        }
    }

    void Update()
    {
        if (morphed == false && canTransform == true)
        {
            if (transformTime > 0)
            {
                transformTime -= Time.deltaTime;
            }
            else
            {
                randomTransformation();
            }
            if (transformTime < 1 && morphed == false && canTransform == true)
            {
                sophieParticles.SetActive(true);
            }
        }
    }

    private void randomTransformation()
    {
        if (morphed == false)
        {
            vectorforobject = notMorphedPrefab.transform.position;
            morphedPrefab.transform.position = vectorforobject;
            notMorphedPrefab.SetActive(false);
            morphedPrefab.SetActive(true);
            morphed = true;
            canUnmorph = false;
            lastTick = 0.0f;
            time = 0.0f;
        }
    }

    void unMorphTime()
    {
        if ((time - lastTick) > tickUnmorph)
        {
            lastTick = time;
            canUnmorph = true;
        }
    }
}
