using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    [SerializeField]private bool nextRoom = true;
    [SerializeField] private bool isPhilozopherStone;

    [SerializeField] private GameObject nextRoomGameobjects;
    [SerializeField] private GameObject nextRoomUIObjects;

    [SerializeField] private GameObject previousRoomGameobjects;
    [SerializeField] private GameObject previousRoomUIObjects;
    public void NextRoom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousRoom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

    private void OnMouseDown()
    {
        if(nextRoom)
        {
            nextRoomGameobjects.SetActive(true);
            nextRoomUIObjects.SetActive(true);

            previousRoomGameobjects.SetActive(false);
            previousRoomUIObjects.SetActive(false);
        }
        if(!nextRoom)
        {
            previousRoomGameobjects.SetActive(true);
            previousRoomUIObjects.SetActive(true);

            nextRoomGameobjects.SetActive(false);
            nextRoomUIObjects.SetActive(false);
        }
        if(isPhilozopherStone)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
