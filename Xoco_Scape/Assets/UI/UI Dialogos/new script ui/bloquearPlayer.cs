using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloquearPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
