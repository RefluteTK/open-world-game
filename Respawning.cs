using System.Security;
using System.Collections;
using UnityEngine;

public class Respawning: MonoBehaviour



{
[SerializeField] private Transform Player;
[SerializeField] private Transform respawpoint;


    void OnTriggerEnter(Collider other)
    {
    Player.transform.position = respawpoint.transform.position;

    

    }
}

