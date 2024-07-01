using UnityEngine;
using UnityEngine.Events;

public class EjemploAplicaciónDinámica : MonoBehaviour
{
    [SerializeField] EjemploUnityEvent unityEvent;

    private void OnEnable()
    {
        unityEvent.evento.AddListener(Metodo); // De esta forma nos suscribimos al evento
    }

    private void OnDisable()
    {
        unityEvent.evento?.RemoveListener(Metodo); // De esta forma nos desuscribimos. 
                                                   // Es necesario verificar que evento no sea nulo
                                                   // para evitar errores

        unityEvent.evento?.RemoveAllListeners();   // De esta forma limpiamos el evento y no 
                                        // realizará ningún callback
    }

    private void Metodo()
    {
        Debug.Log("Llamado método");
    }
}
