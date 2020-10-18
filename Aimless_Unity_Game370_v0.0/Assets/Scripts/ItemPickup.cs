using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;
    // Allows player to pick up item when "True"
    private bool pickUpAllowed;

    //  when walking towards an item
    private void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    private void Update()
    {
        // Press "E" to pick item up
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        // adds/picks up item
        Destroy(gameObject);
    }
}
