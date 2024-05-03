using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static DataManager instance;
    public List<ItemData> items = new List<ItemData>();

    public GameData()
    {
        items = new List<ItemData>();
    }

  
    public void AddItem(ItemData newItem)
    {
        foreach (ItemData item in items)
        {
            if (item.identificador == newItem.identificador)
            {
                item.count += newItem.count;
                return;
            }
        }
       
        items.Add(newItem);
    }

    public int GetItemCount(string identifier)
    {
        foreach (ItemData item in items)
        {
            if (item.identificador == identifier)
            {
                return item.count;
            }
        }
        return 0;
    }
}
