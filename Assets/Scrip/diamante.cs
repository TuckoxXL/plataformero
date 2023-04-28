using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamante : MonoBehaviour
{
    public Timer _timer;

    // Start is called before the first frame update
    void Start()
    {
        _timer = GameObject.FindGameObjectWithTag("timer").GetComponent<Timer>();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _timer.sumarTiempo();
            Destroy(gameObject);
        }
    }
}
