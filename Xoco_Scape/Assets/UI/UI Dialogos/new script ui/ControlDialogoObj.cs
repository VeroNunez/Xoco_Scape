using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDialogoObj : MonoBehaviour
{
    public GameObject dialogoObj;
    public Text txtDialogoObj;
    [Header("Config de teclado")]
    public KeyCode teclaSiguienteFrase2;
    //public KeyCode teclaSiguienteFrase1;
    [Header("Ensayos")]
    public FraseObj[] dialogoEnsayoObj;
    public bool objAct;


    // Start is called before the first frame update
    void Start()
    {
        dialogoObj.GetComponent<Animator>().SetBool("Cartel", false);
        dialogoObj.GetComponent<Animator>().SetBool("Objeto", false);
        objAct = false;
    }

    // Update is called once per frame


    public IEnumerator DecirObj(FraseObj[] _dialogo)
    {
        dialogoObj.GetComponent<Animator>().SetBool("Cartel", true);
        //objAct = false;
        for (int i = 0; i < _dialogo.Length; i++)
        {
            txtDialogoObj.text = _dialogo[i].textoObj;
            yield return new WaitForSeconds(0.5f);
            yield return new WaitUntil(() => Input.GetKeyDown(teclaSiguienteFrase2));
        }
        dialogoObj.GetComponent<Animator>().SetBool("Cartel", false);
        objAct = true;
        //dialogo.SetActive(true);


    }

    //[ContextMenu("Activar prueba")]

    //public void Prueba()
    public void popDialogoObj()
    {
        StartCoroutine(DecirObj(dialogoEnsayoObj));

       


    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //popDialogoObj();
        //}

        //if (Input.GetKeyDown(teclaSiguienteFrase1))
        //{
        

        //}

    }
}

[System.Serializable]
public class FraseObj
{
    public string textoObj;
}
