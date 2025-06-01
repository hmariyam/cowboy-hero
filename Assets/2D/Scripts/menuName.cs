using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 
//Leen Al Harash

public class menuName : MonoBehaviour {

    public TMP_InputField nameInputField;
    private static string playerName = "";
    public static string PlayerName => playerName;  //get pour l'insérer dans le win/lose menu
    
    void Start() {
        Time.timeScale = 1;
    }
    
    //insertion du nom
    public void ReadStringInput(string s) {
        playerName = s.Trim();
    }

    public void StartLevel(string levelName) {

         if (string.IsNullOrEmpty(playerName)) {
            playerName = nameInputField.text.Trim();
            return; //pour ne pas faire fonctionner les boutons
        }

        //affichage soit niveau 2d ou 3d
        SceneManager.LoadScene(levelName);
    }
}