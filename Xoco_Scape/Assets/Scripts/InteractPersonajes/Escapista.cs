using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escapista : MonoBehaviour
{
    public bool isOpen;

    public GameObject Player;

    //public GameObject di�logo;    **poner el start en apagado
    //public GameObject di�logoGracias;    **poner el start en apagado

    public void HablarEscapista()
    {
        if (!isOpen)
        {
            isOpen = true;           
            Player.GetComponent<PlayerManager>().TareaPasador = 1;

            if (Player.GetComponent<PlayerManager>().pasador == 1)
            {
                //Aqui va di�logo FIN
            }

            //Aqui va el di�logo

            Debug.Log("Hablaste con Escapista");
        }
    }

    public void DejarDeHablar()
    {
        isOpen = false;
        //Desactivar di�logos
    }
}
