using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escapista : MonoBehaviour
{
    public bool isOpen;

    public GameObject Player;

    //public GameObject diálogo;    **poner el start en apagado
    //public GameObject diálogoGracias;    **poner el start en apagado

    public void HablarEscapista()
    {
        if (!isOpen)
        {
            isOpen = true;           
            Player.GetComponent<PlayerManager>().TareaPasador = 1;

            if (Player.GetComponent<PlayerManager>().pasador == 1)
            {
                //Aqui va diálogo FIN
            }

            //Aqui va el diálogo

            Debug.Log("Hablaste con Escapista");
        }
    }

    public void DejarDeHablar()
    {
        isOpen = false;
        //Desactivar diálogos
    }
}
