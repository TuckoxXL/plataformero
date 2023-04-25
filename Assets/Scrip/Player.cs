using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Forcemultiplier;
    public float jumforce;
    public bool canjump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canjump = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;
        //float verticalforce = Input.GetAxis("Vertical") * Forcemultiplier;

        horizontalforce *= Time.deltaTime;
        //verticalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && canjump == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumforce, 0);
            canjump = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canjump = false;
        }

        if (collision.gameObject.tag == "Pinchos")
        {
            SceneManager.LoadScene("Derrota");
        }
    }

}
