using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menupausa : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject interfaz;
    void Start()
    {
        Desactivar();
    }

    public void Activar()
    {
        gameObject.SetActive(true);
        interfaz.SetActive(false);
    }

    public void Desactivar()
    {
        gameObject.SetActive(false);
        interfaz.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       
        if(gameObject == enabled)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene(0);
            }
        }
        
    }
}
