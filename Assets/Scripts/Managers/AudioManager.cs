using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Arrays para los sonidos y la m�sica del juego
    public AudioSource[] sfx;
    public AudioSource[] bgm;

    //Hacemos una referencia (Singleton) 
    public static AudioManager instance;

    private void Awake()
    {
        //Inicializamos el Singleton si est� vac�o
        if (instance == null) instance = this;
        //Hace que el AudioManager no sea destruido al cambiar entre escenas
        DontDestroyOnLoad(gameObject);
    }

    //M�otodo para reproducir un sonido pasado por par�metro
    public void PlaySFX(int soundToPlay)
    {
        //S�lo si el sonido existe lo para por si ya estuviera sonando, y lo reproduce
        if (soundToPlay < sfx.Length)
        {
            sfx[soundToPlay].Stop();
            sfx[soundToPlay].Play();
        }
    }

    //M�otodo que reproduce una m�sica pasada por par�metro
    public void PlayBGM(int musicToPlay)
    {
        //Si no se est� reproduciendo ya la m�sica que queremos, se paran todas y se reproduce la seleccionada si existe
        if (!bgm[musicToPlay].isPlaying)
        {
            StopMusic();

            if (musicToPlay < bgm.Length)
            {
                bgm[musicToPlay].Play();
            }
        }
    }

    //M�todo que para m�sica
    public void StopMusic()
    {
        //Para cualquier m�sica que estuviera sonando
        for (int i = 0; i < bgm.Length; i++)
        {
            bgm[i].Stop();
        }
    }
}
