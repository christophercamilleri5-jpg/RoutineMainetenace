using Game.Scripts;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Vector3 offset = Vector3.up;
    
    public void Interact(Inventory inventory)
    {
        var origin = transform.position + offset;
        if (!Physics.Raycast(origin, transform.forward, out var hitInfo, 2f))
            return; //raycasting meaning it will shoot foward and when hit it will return back the data information. it's is a class

        Debug.Log($"Object: {hitInfo.collider.name}");
        
        // Find and return a component if it exists
        if (hitInfo.collider.TryGetComponent(out Door door))
        {
            door.Open();
        }

        
        if (hitInfo.collider.TryGetComponent(out IInteractable interactable))
        {
            interactable.Interact(inventory);// if this has error make sure you get it from the main code from above and add the name from it
        }
        
        
        //This was the other class but the issue will be that if there's a lot of interaction it will be long to managed
        //if (hitInfo.collider.TryGetComponent(out itemfuse fuse))
       // {
        //    fuse.Interact();
        //}
    }
}
