using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotasManager : MonoBehaviour {
    public GameObject notaPrefab;
    private GameObject contadorPuntos;
    private int contador = 0;
    private string[] botones = { "z", "x", "c", "v" };
    Vector3 carril = new Vector3(0, 4, 0);
    private float spawnrate;
    private SoundManager audio;


    void Start() {
        Debug.Log("Start");
        contadorPuntos = GameObject.Find("ContadorPuntuacion");
        audio = this.gameObject.GetComponent<SoundManager>();
    }

    void Update() {
        if (Time.time >= spawnrate) generarNota();
    }

    public void generarNota() {

        spawnrate = Random.Range(0.3f, 3f) + Time.time;
        switch ((int) Random.Range(1f, 4f)) {
            case 1:
                carril.x = -3;
                break;
            case 2:
                carril.x = -1;
                break;
            case 3:
                carril.x = 1;
                break;
            case 4:
                carril.x = 3;
                break;
        }
        Instantiate(notaPrefab, carril, notaPrefab.transform.rotation);
    }

    public void entraEnElColiderDeBoton(Boton boton, GameObject colision) {
        if (Input.GetButton(botones[(int)boton])) {
            contador++;
            contadorPuntos.GetComponent<TextMesh>().text = "x" + contador;
            Destroy(colision);
            audio.playSucces();
        }
    }

    public void haSalidoDelTrigger(GameObject colision) {
        audio.playFailure();
        colision.GetComponent<SpriteRenderer>().color = Color.red;
    }
}

public enum Boton {z, x, c, v}
