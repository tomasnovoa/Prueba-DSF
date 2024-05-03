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

           if (dataItem != null)
            {
                
                DataManager.data.AddItem(dataItem);
                DataManager.Save();
                Destroy(hit.gameObject);
            }
          

        }
    }


}
