using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
// Auteur : Hanfaoui Mariyam
public class NomJoueur : MonoBehaviour
{
    // D�claration des variables
    public TextMeshProUGUI nomJoueurText;

    void Start()
    {
        string name = menuName.PlayerName;
        nomJoueurText.text = $"Joueur : {name}";
    }
}
