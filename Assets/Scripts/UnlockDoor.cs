using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject door = null;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DoorCard"))
        {
            Debug.Log("Card is in door trigger");

            if (door.activeInHierarchy)
            {
                door.SetActive(false);
            }
        }
    }
}
