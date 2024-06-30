using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.Events;

public class EjemploUnityEvent : MonoBehaviour
{
    public UnityEvent evento;

    private void OnEnable()
    {
        evento.AddListener(Metodo);
    }

    private void OnDisable()
    {
        evento?.RemoveAllListeners();
    }

    private void Metodo()
    {

    }
}
