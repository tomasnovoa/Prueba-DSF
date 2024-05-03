using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boton : MonoBehaviour
{
    private SOItem currentItems;
    private System.Action<SOItem> Onintput;
    public TextMeshProUGUI numeros;
    

    public void interact()
    {
        Onintput?.Invoke(currentItems);
    }

    public void Initialize(SOItem item, System.Action<SOItem> onintput)
    {
        Onintput = onintput;
        currentItems = item;

        numeros.text = DataManager.data.GetItemCount(item.name).ToString();

    }
  
}
