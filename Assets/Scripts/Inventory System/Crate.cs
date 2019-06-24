using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : CollectibleObject
{
    [SerializeField]
    private float collectTime = 2f;

    [SerializeField]
    private int keyId;

    private bool isOpen = false;

    private float currentTime = 0f;
    private bool collecting = false;

    private InventorySystem inventory;

    private void Start()
    {
        inventory = FindObjectOfType<InventorySystem>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")   // Player Collect tuşu ile objeyi envantere alıyor.
        {
            if (Input.GetKey(GameManager.GetCollectKeyCode()) && !collecting && inventory.GetCurrentKey() == keyId) // current anahtar sandık anahtarı ile doğruysa
            {
                collecting = true;
                StartCoroutine(Collect()); // current time kadar basılı tutuyor mu kontrol eder.
                
            }
            else
            {
                collecting = false; // elini çektiyse collecting iptal.
            }
        }
    }

    IEnumerator Collect()
    {
        while (true)
        {
            if (collecting)
            {
                yield return new WaitForSeconds(0.1f);
                currentTime += 0.1f;
                if (!collecting)
                {
                    break; // elini çektiyse collecting iptal.
                }
                else if (currentTime >= collectTime) // kutu açıldı.
                {
                    Debug.Log("Objeyi Aldın.");
                    AddInventory();
                    isOpen = true;
                    //kutu açılma animasyonu vs..
                }
            }
        }
    }


    protected override void AddInventory()
    {
        FindObjectOfType<GameManager>().AddInventoryItem(this);
    }

    public int GetKey()
    {
        return keyId;
    }

    public bool GetIsOpen()
    {
        return isOpen;
    }

    public void SetIsOpen(bool isOpen)
    {
        this.isOpen = isOpen;
    }

}
