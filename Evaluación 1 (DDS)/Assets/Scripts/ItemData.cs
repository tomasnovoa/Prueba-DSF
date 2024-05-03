using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class ItemData 
{
    public string identificador;
    public int count;

    public ItemData(string identifier, int count)
    {
        this.identificador = identifier;
        this.count = count;
    }
}
