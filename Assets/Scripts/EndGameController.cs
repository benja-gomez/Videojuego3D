using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameController : MonoBehaviour
{
    public Button buttonStart;

    public Text gameTextLost;

    public Text gameTextWin;

    public Text playerName;

    public Text playerCrystals;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        playerName.text = "NOMBRE: " + InputValidation.playerName;
        playerCrystals.text = "CRISTALES: " + PlayerStats.crystals;
        buttonStart.onClick.AddListener (volverJugar);
        if (PlayerStats.ganaste)
        {
            gameTextLost.enabled = false;
            gameTextWin.enabled = true;
        }
        else
        {
            gameTextLost.enabled = true;
            gameTextWin.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void volverJugar()
    {
        PlayerStats.crystals = 0;
        PlayerStats.currentHealth = 1000;
        FlashlightController.currentCharge = 1000;
        FlashlightController.isOn = false;
        PlayerStats.ganaste = false;
        // MorphScript.morphedPrefab.SetActive(false);
        // SophieScript.notMorphedPrefab.SetActive(true);
        // MorphController.canTransform = false;
        // MorphController.morphed = false;

       

        Initiate.Fade("Level_01", Color.black, 2f);
    }
}
