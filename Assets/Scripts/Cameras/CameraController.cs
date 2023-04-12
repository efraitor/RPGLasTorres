using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps; //Para usar 

public class CameraController : MonoBehaviour
{
    //Camera follow this target position
    public Transform target;

    //M�sica a reproducir en esta escena
    public int musicToPlay;
    //Para comprobar si la m�sica ya est� sonando
    private bool musicStarted;

    // Use this for initialization
    void Start()
    {
        //Get the transform of the Player
        target = FindObjectOfType<PlayerController>().transform;

    }

    // LateUpdate is called once per frame after Update (to prevent camera glitches when follow Player)
    void LateUpdate()
    {
        //Camera follow Player position
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

        //Si no ha empezado la m�sica, le decimos que ahora s� y la reproducimos
        if (!musicStarted)
        {
            musicStarted = true;
            AudioManager.instance.PlayBGM(musicToPlay);
        }
    }
}
