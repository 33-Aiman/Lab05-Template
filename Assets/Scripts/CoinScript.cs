using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int rotateSpeed;

    public Transform explosion;

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject exploder = ((Transform)Instantiate(explosion, this.transform.position,
                this.transform.rotation)).gameObject;
            Destroy(exploder, 2.0f);
        }
    }
}
