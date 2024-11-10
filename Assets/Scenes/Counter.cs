using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;

    private void Start()
    {
        //Count = 0;
        // Pokud je skóre již uloženo, nastav ho
        Count = PlayerPrefs.GetInt("HighScore", 0);  // "HighScore" je klíč, 0 je výchozí hodnota
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("Ovoce"))
        {
            Count += 1;
            UpdateScoreText();
            Destroy(other.gameObject);  // Zničíme ovoce, nikoli tento objekt
            
            // Uložím nové skóre, pokud je vyšší než aktuální highscore
            if (Count > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", Count);  // Uložím nové HighScore
            }
        }
    }
    private void UpdateScoreText()
    {
        CounterText.text = "Count : " + Count;
    }

    // Funkce pro načtení a zobrazení HighScore
    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("HighScore", 0);  // Vrátí uložené skóre
    }
}
