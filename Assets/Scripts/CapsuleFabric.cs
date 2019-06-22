using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Instanciar un objeto al iniciar la app
public class CapsuleFabric : MonoBehaviour
{
    public GameObject capsulePrefab;
    public int capsulesNumber;
    public Vector2 minMaxX;
    public Vector2 minMaxZ;

    // Devolver un Vector aleatorio
    public Vector3 RandomPosition
    {
        get {
            var v = Vector3.zero;
            v.x = Random.Range(minMaxX.x, minMaxX.y);
            v.z = Random.Range(minMaxZ.x, minMaxZ.y);

            return v;
        }
    }

    void Start()
    {
        for (int i = 0; i < capsulesNumber; i++)
        {
            InstanceCapsule();
        }
    }

    void InstanceCapsule()
    {
        Instantiate(capsulePrefab, RandomPosition, Random.rotation);
    }

}
