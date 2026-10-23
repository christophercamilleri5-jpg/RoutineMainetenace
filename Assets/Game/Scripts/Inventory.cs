using System.Collections.Generic;

public class Inventory
{
   //Creates a list of item as soon as this Class starts to exist.
   private List<ItemType> items = new();

   
   /// <summary>
   /// Adds an item to the inventory
   /// </summary>
   /// <param name="item"></param>
   public void Add(ItemType item)
   {
      items.Add(item);
   }
   
   /// <summary>
   /// Removes and item from the inventory
   /// </summary>
   /// <param name="item"></param>
   public void Remove(ItemType item)
   {
      items.Remove(item);
   }

   /// <summary>
   /// Checks the inventory for an item.
   /// </summary>
   /// <param name="item"></param>
   /// <returns></returns>
   public bool Contains(ItemType item) => items.Contains(item); // => will remove the {}
}


