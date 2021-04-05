using System.Security;
using System.Collections;
using UnityEngine;

public class Respaw: MonoBehaviour


{
[SerializeField] private Transform Player;
[SerializeField] private Transform respaw;


    void OnTriggerEnter(Collider other)
    {
    Player.transform.position = respaw.transform.position;

    

    }
}

