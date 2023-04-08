using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
	//Referencia al objeto jugador
	public GameObject player;
	//Posición de aparición del jugador
	public Vector3 initialPos;

	// Use this for initialization
	void Start()
	{
		//Si a priori no hay ningun Player en la escena
		if (PlayerController.instance == null)
			//Instanciamos uno nuevo en la posición deseada
			Instantiate(player, initialPos, transform.rotation);
		//Si existe un jugador en la escena
		else
			Destroy(gameObject);
	}
}
