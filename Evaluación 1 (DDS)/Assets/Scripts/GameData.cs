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

    // Método AddItem modificado para aceptar un objeto DataItem
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
        // Si no se encuentra el ítem, agregarlo a la lista
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
