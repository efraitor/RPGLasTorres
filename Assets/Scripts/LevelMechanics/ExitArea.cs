using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Librería para el cambio entre escenas

public class ExitArea : MonoBehaviour
{
    //Nombre de la escena a cargar
    public string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método para conocer cuando el jugador entra en el área de cambio de nivel
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Cargamos la escena a la que queremos ir
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
