using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Velocidad de movimiento del jugador
    public float moveSpeed;

    //Referencia al RigidBody del jugador
    private Rigidbody2D theRB;
    //Referencia al Animator del jugador
    private Animator anim;

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
    }

}