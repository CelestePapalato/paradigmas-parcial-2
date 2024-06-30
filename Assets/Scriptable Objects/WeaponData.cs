using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Data",
menuName = "ScriptableObjects/Weapon Data",
order = 1)]

public class WeaponData : ScriptableObject
{
    [SerializeField]
    string nombreDelArma;
    [SerializeField]
    int daño;
    [SerializeField]
    float rango;

    public string Nombre { get => nombreDelArma; }
    public int Daño { get => daño; }
    public float Rango { get => rango; }

}