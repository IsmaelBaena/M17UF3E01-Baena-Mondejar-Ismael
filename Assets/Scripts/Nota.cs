using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour {
    private float tiempoAntesDeMorir = 5f;
    
    void Start() {
        tiempoAntesDeMorir = tiempoAntesDeMorir + Time.time;
    }

    void Update() {
        if (Time.time >= tiempoAntesDeMorir) {
            Destroy(this.gameObject);
        }
    }
}
