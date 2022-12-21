using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputValidation : MonoBehaviour
{
    // Start is called before the first frame update
    public static int playerAge;

    public static string playerName;

    public InputField username;

    public InputField age;

    public Button buttonStart;

    public Text errorTextAge;

    public Text errorTextName;

    int newValue;

    bool usernameValid = false;

    bool ageValid = false;

    void Start()
    {
        errorTextName.text = "";
        errorTextAge.text = "";
        buttonStart.onClick.AddListener (iniciarJuego);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void iniciarJuego()
    {
        if (int.TryParse(age.text, out newValue))
        {
            if (newValue < 18)
            {
                errorTextAge.text = "No tiene la suficiente edad para jugar";
                ageValid = false;
            }
            else
            {
                errorTextAge.text = "";
                ageValid = true;
                playerAge = newValue;
            }
        }
        else
        {
            errorTextAge.text = "Debe Ingresar su Edad";
            ageValid = false;
        }
        if (!(username.text.Length >= 1 && username.text.Length <= 20))
        {
            errorTextName.text = "El nombre debe tener entre 1 y 20 caracteres";
            usernameValid = false;
        }
        else
        {
            errorTextName.text = "";
            usernameValid = true;
            playerName = username.text;
        }

        if (ageValid && usernameValid)
        {
            Initiate.Fade("Level_01", Color.black, 2f);
        }
    }
}
