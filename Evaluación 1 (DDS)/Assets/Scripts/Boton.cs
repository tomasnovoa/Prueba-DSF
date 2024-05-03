using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boton : MonoBehaviour
{
    private SOItem currentItems;
    private System.Action<SOItem> Onpress;
    public TextMeshProUGUI numeros;
    

    public void interact()
    {
        Onpress?.Invoke(currentItems);
    }

    public void Initialize(SOItem item, System.Action<SOItem> onpress)
    {
        Onpress = onpress;
        currentItems = item;

        numeros.text = DataManager.data.GetItemCount(item.name).ToString();

    }
  
}
