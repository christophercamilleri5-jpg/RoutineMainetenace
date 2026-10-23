using System;
using Game.Scripts;
using UnityEngine;

public class itemfuse : MonoBehaviour, IInteractable
{

    public void Interact(Inventory inventory)//when the pramry code is changed this need to be changed too
    {
        inventory.Add(ItemType.Fuse);// this will now be added on the inventory list.
        Destroy(gameObject);
    }
}
