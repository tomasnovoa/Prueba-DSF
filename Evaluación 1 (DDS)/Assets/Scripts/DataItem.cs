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
        if (soitem != null)
        {
            // Inicializar los campos de DataItem con la información de SOItem
            Nombre = soitem.name;
            Descripcion = soitem.Description;
            Imagen = soitem.Icon;
        }
        else
        {
            // Si soitem es nulo, mostrar un mensaje de error
            Debug.LogError("SOItem no está asignado en el objeto DataItem.");
        }

    }
    public DataItem(string identifier, int count) : base(identifier, count)
    {
        Nombre = soitem.name;
        Descripcion = soitem.Description;
        Imagen = soitem.Icon;
    }

}
