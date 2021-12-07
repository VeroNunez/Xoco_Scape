using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    //Tareas
    public int TareaPasador = 0;
    public int TareaEntregarCarta = 0;
    public int TareaBufanda = 0;
    public int TareaAlegrar = 0;
    public int TareaCepillo = 0;


    //Items
    public int pasador = 0;
    public int carta = 0;
    public int bufanda = 0;
    public int cepillo = 0;

    //Tareas Ui
    public GameObject tpasador;
    public GameObject tcarta;
    public GameObject tcepillo;
    public GameObject tbufanda;

    //Objetos
    public GameObject objCarta;
    public GameObject objCarta2;
    public GameObject objBufanda;
    public GameObject objBufanda2;
    public GameObject objCepillo;
    public GameObject objCepillo2;
    public GameObject objPasador;
    public GameObject objPasador2;

    //bloqueos de pecera
    public GameObject plano1;
    public GameObject plano2;



    // Start is called before the first frame update

    void ActiveTareas()
    {
        if (TareaPasador == 1)
        {
            tpasador.SetActive(true);
        }

        if (TareaAlegrar == 1)
        {
            tcarta.SetActive(true);
        }

        if (TareaCepillo == 1)
        {
            tcepillo.SetActive(true);
        }

        if (TareaBufanda == 1)
        {
            tbufanda.SetActive(true);
        }
    }

    void ActiveObj()
    {
        if(pasador == 1)
        {
            objPasador.SetActive(true);
            objPasador2.SetActive(true);
        }
        else
        {
            objPasador.SetActive(false);
            objPasador2.SetActive(false);
        }

        if (cepillo == 1)
        {
            objCepillo.SetActive(true);
            objCepillo2.SetActive(true);
        }
        else
        {
            objCepillo.SetActive(false);
            objCepillo2.SetActive(false);
        }

        if (bufanda == 1)
        {
            objBufanda.SetActive(true);
            objBufanda2.SetActive(true);
        }
        else
        {
            objBufanda.SetActive(false);
            objBufanda2.SetActive(false);
        }

        if (carta == 1)
        {
            objCarta.SetActive(true);
            objCarta2.SetActive(true);
        }
        else
        {
            objCarta.SetActive(false);
            objCarta2.SetActive(false);
        }
    }

    void desbloqueo()
    {
        if(TareaPasador == 1)
        {
            plano1.SetActive(false);
            plano2.SetActive(false);
        }
        
    }

    void Start()
    {
        tpasador.SetActive(false);
        tcarta.SetActive(false);
        tcepillo.SetActive(false);
        tbufanda.SetActive(false);

        objCarta.SetActive(false);
        objCarta2.SetActive(false);
        objBufanda.SetActive(false);
        objBufanda2.SetActive(false);
        objCepillo.SetActive(false);
        objCepillo2.SetActive(false);
        objPasador.SetActive(false);
        objPasador2.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        ActiveTareas();
        ActiveObj();
        desbloqueo();
    }
}
