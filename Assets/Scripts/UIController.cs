using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject openTheDoor;

    [SerializeField]
    private GameObject closeTheDoor;

    [SerializeField]
    private GameObject youHaveNotCorrectKey;

    [SerializeField]
    private GameObject pickUp;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ShowOpenTheDoor()
    {
        openTheDoor.SetActive(true);
    }

    public void HideOpenTheDoor()
    {
        openTheDoor.SetActive(false);
    }
    public void ShowYouHaveNotCorrectKey()
    {
        youHaveNotCorrectKey.SetActive(true);
    }

    public void HideYouHaveNotCorrectKey()
    {
        youHaveNotCorrectKey.SetActive(false);
    }

    public void ShowPickUp()
    {
        pickUp.SetActive(true);
    }
    public void HidePickUp()
    {
        pickUp.SetActive(false);

    }
    public void ShowCloseTheDoor()
    {
        closeTheDoor.SetActive(true);
    }

    public void HideCloseTheDoor()
    {
        closeTheDoor.SetActive(false);
    }
}
