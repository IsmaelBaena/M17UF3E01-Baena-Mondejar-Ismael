using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPista : MonoBehaviour{
    private NotasManager notaManager;
    public Boton boton;

    void Start() {
        notaManager = GameObject.Find("Manager").GetComponent<NotasManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision) {
        notaManager.entraEnElColiderDeBoton(boton, collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision) {
        notaManager.haSalidoDelTrigger(collision.gameObject);
    }
}
