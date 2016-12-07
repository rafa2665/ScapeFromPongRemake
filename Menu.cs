using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public void Iniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase1");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
