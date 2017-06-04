using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter2D(Collider2D collision)
    {
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            if (collision.gameObject.tag.Equals("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
