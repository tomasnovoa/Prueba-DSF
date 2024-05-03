using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataItem : ItemData
{

    public string Nombre;
    public string Descripcion;
    public Sprite Imagen;
    public SOItem soitem;
   

    private void Start()
    {
       

    }
    public DataItem(string identifier, int count) : base(identifier, count)
    {
        Nombre = soitem.name;
        Descripcion = soitem.Description;
        Imagen = soitem.Icon;
    }

}
