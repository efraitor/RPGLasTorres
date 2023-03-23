using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    //El nombre del �rea de la escena donde queremos aparecer
    public string transitionName;

    // Start is called before the first frame update
    void Start()
    {   
        //Si el �rea a donde debemos ir, coincide con la que tiene guardada el jugador
        if (transitionName == PlayerController.instance.areaTransitionName)
        {
            //Igualamos la posici�n del jugador a la de esa �rea
            PlayerController.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
