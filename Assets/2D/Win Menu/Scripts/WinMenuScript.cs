//Leen Al Harash
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinMenuScript : MonoBehaviour {

    public TextMeshProUGUI winText;

    void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        string name = menuName.PlayerName;
        winText.text = $"Hooray {name} !! \nVous avez gagné!!";
    }

    //retourner au menu
    public void Retourner(){
        SceneManager.LoadSceneAsync(0);
    }
    
    public void QuitGame(){
        Application.Quit();
    }
}