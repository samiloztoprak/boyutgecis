using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CollectibleObject : MonoBehaviour
{
    [SerializeField]
    private string name;

    private UIController uiController;
    public string GetName()
    {
        return name;
    }

    private void Start()
    {
        uiController = FindObjectOfType<UIController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            uiController.ShowPickUp();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")   // Player Collect tuşu ile objeyi envantere alıyor.
        {
            if (Input.GetKeyDown(GameManager.GetCollectKeyCode()))
            {
                Debug.Log("Objeyi Aldın.");
                AddInventory();
                uiController.HidePickUp();
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")  
        {
            uiController.HidePickUp();
        }
    }
    protected virtual void AddInventory()
    {
        FindObjectOfType<GameManager>().AddInventoryItem(this);
    }

}
