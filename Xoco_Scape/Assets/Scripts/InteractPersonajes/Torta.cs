using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torta : MonoBehaviour
{
    public bool isOpen;

    public GameObject Player;
    public void HablarTorta()
    {
        if (!isOpen)
        {
            isOpen = true;
            Player.GetComponent<PlayerManager>().TareaCepillo = 1;

            if (Player.GetComponent<PlayerManager>().cepillo == 1)
            {
                Player.GetComponent<PlayerManager>().pasador = 1;
                Player.GetComponent<PlayerManager>().cepillo = 0;

                //Aqui va di�logo GRACIAS 

            }
            else
            {
                //Aqui va di�logo qu� necesita
            }
            Debug.Log("Hablaste con Torta");
        }
    }

    public void DejarDeHablar()
    {
        isOpen = false;
    }
}
