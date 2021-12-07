using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloquearPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject DialogoOff1;
    public GameObject DialogoOff2;
    void Start()
    {
        
    }

    public void Alto()
    {
        Player.GetComponent<MovimientoXoco>().enabled = false;
    }

    public void Siga()
    {
        Player.GetComponent<MovimientoXoco>().enabled = true;
        
    }

    public void desactivar()
    {
        DialogoOff1.SetActive(false);
        DialogoOff2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
