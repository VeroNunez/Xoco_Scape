using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalaBacitoAmaranto : MonoBehaviour
{
    public bool isOpen;

    public GameObject Player;
    public GameObject dialogoCa;
    public GameObject dialogofinalCa;

    //public GameObject diálogo;    **poner el start en apagado
    //public GameObject diálogoGracias;    **poner el start en apagado

    public void HablarCaballos()
    {
        if (!isOpen)
        {
            isOpen = true;
            Player.GetComponent<PlayerManager>().TareaBufanda = 1;

            if (Player.GetComponent<PlayerManager>().bufanda == 1)
            {
                Player.GetComponent<PlayerManager>().cepillo = 1;
                Player.GetComponent<PlayerManager>().bufanda = 0;
                //Aqui va diálogo GRACIAS
                dialogofinalCa.GetComponent<ControlDialogoObj>().popDialogoObj();
            }
            else
            {
                //Aqui va diálogo qué necesita
                dialogoCa.GetComponent<ControlDialogos>().popDialogo();
            }

            Debug.Log("Hablaste con calabacito y amaranto");
        }
    }

    public void DejarDeHablar()
    {
        isOpen = false;
        //Desactivar diálogos

    }
}
