//Leen Al Harash
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour {

    // Declaration d'une variable pour initialiser le compteur des balles
    public int balleCompteur = 0;
    public TextMeshProUGUI gameOverText;

    void Start() {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        string name = menuName.PlayerName;
        gameOverText.text = $"lol vous avez perdu {name} ! \nVoulez-vous revenir au menu?";
    }

    //retourner au menu
    public void RePlayGame(){
        CollisionBalle.balleCompteur = PlayerPrefs.GetInt("CompteurBalle");
        CollisionBalle.balleCompteur = balleCompteur;
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame(){
        Application.Quit();
    }
}