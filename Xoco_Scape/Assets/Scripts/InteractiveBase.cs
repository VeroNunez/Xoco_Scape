using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InteractiveBase : MonoBehaviour 
{

    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public UnityEvent dejaDeHablar;

    private void Start()
    {
        //mipanel.SetActive(false);
    }
    private void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
        if (isInRange == false)
        {
                dejaDeHablar.Invoke();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            isInRange = true;
            Debug.Log("jugador en rango");
            //mipanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("jugador fuera de rango");
            //mipanel.SetActive(false);

        }
    }
}
