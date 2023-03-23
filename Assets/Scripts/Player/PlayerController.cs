using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Velocidad de movimiento del jugador
    public float moveSpeed;

    //Nombre del �rea a la que vamos
    public string areaTransitionName;

    //Referencia al RigidBody del jugador
    private Rigidbody2D theRB;
    //Referencia al Animator del jugador
    private Animator anim;

    //Hacemos una referencia (Singleton) 
    public static PlayerController instance;

    private void Awake()
    {
        //Inicializamos el Singleton si est� vac�o
        if (instance == null) instance = this;
        //Si no lo est� 
        else
        {
            //Si hay otro objeto que no sea este, es destruido (evitamos la duplicaci�n del jugador en el cambio entre escenas)
            if (instance != this) Destroy(gameObject);
        }
        //Hace que el jugador no sea destruido al cambiar entre escenas
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        //Inicializamos el RigidBody del jugador
        theRB = GetComponent<Rigidbody2D>();
        //Inicializamos el Animator del jugador
        anim = GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {
        //Movemos al personaje usando la velocidad de su RigidBody, obteniendo los Inputs de los ejes de movimiento
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;


        //ANIMACIONES
        anim.SetFloat("moveX", theRB.velocity.x);
        anim.SetFloat("moveY", theRB.velocity.y);

        //Si hemos pulsado cualquiera de los botones de direcci�n
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            //Metemos como �ltima posici�n en X e Y el �ltimo input realizado
            anim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }

}