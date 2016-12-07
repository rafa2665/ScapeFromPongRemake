using UnityEngine;
using System.Collections;

public class VoltarMenu : MonoBehaviour {

    void Start()
    {
        Invoke("VoltarMenuV", 5);
    }

    void VoltarMenuV()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
