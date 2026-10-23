using UnityEngine;

namespace Game.Scripts
{
    public class Computer : MonoBehaviour, IInteractable
    {
        [SerializeField] private Door door;

        [SerializeField]private bool broken = true; //remember if yu want to change the value from the game inspector use the SerializeField

        public void Interact(Inventory inventory)
        {
            if (broken)
            {
                broken = false;
                return; //meaning when the code of this part if end it goes back to the main code and the door is false
            }

            if (inventory.Contains(ItemType.Fuse))
            {
                door.Open();
                inventory.Remove(ItemType.Fuse);
            }
        }
    }
}