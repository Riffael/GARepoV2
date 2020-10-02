using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject particleFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("It worked!");
        Instantiate(particleFX, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
