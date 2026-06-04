using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Loading_Bay_Door : MonoBehaviour
{
    [SerializeField] private Transform door;
    [SerializeField] private float speed;
    [SerializeField] private float maxlift = 4.0f;
    [SerializeField] private float minlift = 0.0f;
    [SerializeField] private GameObject interact;
    [SerializeField] private GameObject locked;
    private bool up = false;
    private bool down = false;
    private bool InRange = false;
    private string ActiveDoor;
    private Level_Manager level_manager;

    private void Awake()
    {
        level_manager = GameObject.Find("Level Manager").GetComponent<Level_Manager>();
    }

    private void FixedUpdate()
    {
        Interact();
    }

    private void Interact()
    {
        if (up == true && ActiveDoor == level_manager.level_choice)
        {
            float y = door.localPosition.y;
            y += speed * Time.deltaTime;
            y = Mathf.Clamp(y, minlift, maxlift);
            door.localPosition = new Vector3(door.localPosition.x, y, door.localPosition.z);
        }
        if (down == true)
        {
            float y = door.localPosition.y;
            y -= speed * Time.deltaTime;
            y = Mathf.Clamp(y, minlift, maxlift);
            door.localPosition = new Vector3(door.localPosition.x, y, door.localPosition.z);
        }
    }

    public void Check_lock()
    {
        if (InRange == true && ActiveDoor != level_manager.level_choice)
        {
            locked.SetActive(true);
        }
    }

    public void Raise()
    {
        if(InRange == true)
        {
            down = false;
            up = true;
        }
    }
    public void lower()
    {
            down = true;
            up = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        ActiveDoor = gameObject.name;
        if (other.gameObject.tag == "Player")
        {
            InRange = true;
            interact.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interact.SetActive(false);
            locked.SetActive(false);
            InRange = false;
            lower();
        }
    }
}