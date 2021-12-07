using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiodeescena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void juego()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Final()
    {
        SceneManager.LoadScene(2);
    }

    public void Inicio()
    {
        SceneManager.LoadScene(0);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
