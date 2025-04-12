using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float lifetime = 3f;

    void Start()
    {
        Destroy(gameObject, lifetime); // Destruye la bola luego de X segundos
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Destruye enemigo
        }
        Destroy(gameObject); // Destruye la bola
    }
}
