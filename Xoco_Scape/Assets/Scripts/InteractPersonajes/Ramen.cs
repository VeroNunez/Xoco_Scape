using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramen : MonoBehaviour
{
    public bool isOpen;

    public GameObject Player;
    public GameObject dialogofinalR;
    

    //public GameObject diálogo;    **poner el start en apagado

    public void HablarRamen()
    {
        if (!isOpen)
        {
            isOpen = true;
            Player.GetComponent<PlayerManager>().TareaEntregarCarta = 1;
            Player.GetComponent<PlayerManager>().carta = 1;

            //Aqui va el diálogo
            dialogofinalR.GetComponent<ControlDialogoObj>().popDialogoObj();

            Debug.Log("Hablaste con Ramen");
        }
    }

    public void DejarDeHablar()
    {
        isOpen = false;

    }
}
