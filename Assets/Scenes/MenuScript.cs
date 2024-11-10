using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;  // Tato knihovna je nutná pro práci s UI komponentami

public class MenuScript : MonoBehaviour
{
    public TMP_Text highScoreText;  // Přiřaď tento Text komponent z Unity (např. v inspektoru)

    private void Start()
    {
        // Načti a zobraz HighScore z PlayerPrefs
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "Current score: \n" + highScore;
    }
}
