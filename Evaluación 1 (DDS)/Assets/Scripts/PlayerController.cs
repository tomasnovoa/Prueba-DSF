using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameData Data;
    public PhysicalMovement physicalMovement;
    public float speed;
    void Start()
    {

    }

  
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed;
        float z = Input.GetAxisRaw("Vertical") * speed;
        physicalMovement.Move(new Vector3(x, 0, z));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            physicalMovement.Jump();
        }
    }


    public static event System.Action<string> OnItemCollected;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Esfera"))
        {

            DataItem dataItem = hit.gameObject.GetComponent<DataItem>();

            // Verificar si se encontró el componente DataItem
            if (dataItem != null)
            {
                // Agregar el item al DataManager
                DataManager.data.AddItem(dataItem);

                // Guardar los cambios en el DataManager
                DataManager.Save();

                // Destruir el objeto con el que colisionó
                Destroy(hit.gameObject);
            }
            else
            {
                // Si el objeto no tiene el componente DataItem, muestra un mensaje de error o realiza alguna otra acción
                Debug.LogError("El objeto no tiene el componente DataItem adjunto.");
            }

        }
    }


}
