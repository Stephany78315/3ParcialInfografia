using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class AnimacionPinos : MonoBehaviour
{
    // Start is called before the first frame update
    Random rd = new Random();

    public AudioClip Chuza;
    public AudioClip Salto;
    public AudioClip Inicio;

    private AudioSource SonidoJugador;
    void Start()
    {
        SonidoJugador = GetComponent<AudioSource>();
        SonidoJugador.PlayOneShot(Inicio);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Animation>().Play("Idl");
            //SonidoJugador.PlayOneShot(Inicio);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        int rand_num = rd.Next(1, 3);
        Debug.Log(rand_num);
        if (rand_num == 1)
        {
            GetComponent<Animation>().Play("Chusa");
            SonidoJugador.PlayOneShot(Chuza);

        }
        else
        {
            GetComponent<Animation>().Play("Jump");
            SonidoJugador.PlayOneShot(Salto);
        }
        }
    }

