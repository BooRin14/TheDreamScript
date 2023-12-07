using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("key picked up");

            door.GetComponent<BoxCollider2D>().enabled = false;

            this.gameObject.SetActive(false);
        }
    }
}
