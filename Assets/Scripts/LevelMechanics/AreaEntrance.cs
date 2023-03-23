using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    //El nombre del �rea de la escena donde queremos aparecer
    public string transitionName;

    //Dos variables para conocer la direcci�n en la que debe mirar el jugador
    public float dirX, dirY;

    // Start is called before the first frame update
    void Start()
    {   
        //Si el �rea a donde debemos ir, coincide con la que tiene guardada el jugador
        if (transitionName == PlayerController.instance.areaTransitionName)
        {
            //Igualamos la posici�n del jugador a la de esa �rea
            PlayerController.instance.transform.position = transform.position;
            //Accedemos al animator del jugador y le ponemos la direcci�n en la que tiene que mirar inicialmente
            PlayerController.instance.anim.SetFloat("lastMoveX", dirX);
            PlayerController.instance.anim.SetFloat("lastMoveY", dirY);
            //Iniciamos el tiempo de no Input del jugador
            PlayerController.instance.InitialiceNoInput();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
