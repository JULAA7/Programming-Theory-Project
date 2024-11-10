using UnityEngine;
using UnityEngine.SceneManagement;  // Importuj tuto knihovnu pro práci se scénami

public class SceneManagerScript : MonoBehaviour
{
    // Funkce pro přechod do hry (SampleScene)
    public void StartGame()
    {
        SceneManager.LoadScene("Scene");  // Ujisti se, že "SampleScene" je název scény ve tvém projektu
    }

    // Funkce pro ukončení aplikace (Exit)
    public void ExitGame()
    {
        Application.Quit();
    }

    // Funkce pro návrat do hlavní menu
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");  // Ujisti se, že "Menu" je název scény ve tvém projektu
    }
}
