using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDialogos : MonoBehaviour
{
    public GameObject dialogo;
    public Text txtDialogo;
    [Header("Config de teclado")]
    public KeyCode teclaSiguienteFrase;
    [Header("Ensayos")]
    public Frase[] dialogoEnsayo;
    

    // Start is called before the first frame update
    void Start()
    {
        dialogo.GetComponent<Animator>().SetBool("Cartel", false);
    }

    // Update is called once per frame


    public IEnumerator Decir(Frase[] _dialogo)
    {
        dialogo.GetComponent<Animator>().SetBool("Cartel", true);
        for (int i = 0; i < _dialogo.Length; i++)
        {
            txtDialogo.text = _dialogo[i].texto;
            yield return new WaitForSeconds(0.5f);
            yield return new WaitUntil(() => Input.GetKeyDown(teclaSiguienteFrase));
        }
        dialogo.GetComponent<Animator>().SetBool("Cartel", false);
        //dialogo.SetActive(true);


    }

    //[ContextMenu("Activar prueba")]

    //public void Prueba()
    public void popDialogo()
    {
         StartCoroutine(Decir(dialogoEnsayo));
    }

    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.E))
       // {
            //popDialogo();
       // }
    }
}

[System.Serializable]
public class Frase
{
    public string texto;
}
