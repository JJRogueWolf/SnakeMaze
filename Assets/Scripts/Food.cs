using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();
            gameManager.score += 1;
            Destroy(gameObject);
        }
    }
}
