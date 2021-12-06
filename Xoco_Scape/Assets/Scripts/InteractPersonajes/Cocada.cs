using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocada : MonoBehaviour
{
    public bool isOpen;

    public GameObject Player;
    public GameObject dialogoC;
    public GameObject dialogofinalC;

    //public GameObject diálogo;    **poner el start en apagado
    //public GameObject diálogoGracias;    **poner el start en apagado

    public void HablarCocada()
    {
        if (!isOpen)
        {
            isOpen = true;
            Player.GetComponent<PlayerManager>().TareaAlegrar = 1;

            if (Player.GetComponent<PlayerManager>().carta == 1)
            {
                Player.GetComponent<PlayerManager>().bufanda = 1;
                Player.GetComponent<PlayerManager>().carta = 0;
                //Aqui va diálogo GRACIAS 
                dialogofinalC.GetComponent<ControlDialogoObj>().popDialogoObj();

            }
            else
            {
                //Aqui va diálogo qué necesita
                dialogoC.GetComponent<ControlDialogos>().popDialogo();
            }

            Debug.Log("Hablaste con Cocada");
        }
    }

    public void DejarDeHablar()
    {
        isOpen = false;
    }
}
