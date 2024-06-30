using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Data",
menuName = "ScriptableObjects/Weapon Data",
order = 1)]

public class WeaponData : ScriptableObject
{
    [SerializeField]
    string nombreDelArma;
    [SerializeField]
    int da�o;
    [SerializeField]
    float rango;

    public string Nombre { get => nombreDelArma; }
    public int Da�o { get => da�o; }
    public float Rango { get => rango; }

}