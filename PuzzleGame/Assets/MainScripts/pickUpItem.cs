using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpItem : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            
            if (Input.GetKey(KeyCode.E)) {
                //Debug.Log("a tag e player: " + other.gameObject.name);
                // Call a method in the player script to handle the item pickup
                other.GetComponent<ControllerPlayer>().PickUpItem(gameObject);

                // Remove the item from the scene
                Destroy(gameObject);
            }

        }
    }
}
