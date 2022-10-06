using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelColliderStart : MonoBehaviour
{
    public GameObject door;
    public GameObject Player;

    public Sprite openedDoor;
    public Sprite closedDoor;

    private bool triggerEnter = false;

    [SerializeField]
    private Transform playerSpawningPosition;
    [SerializeField]
    private float animationDelay;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!triggerEnter)
        {
            Debug.Log("Starting tutorial");
            Invoke("DoorOpen", 1f + animationDelay);
            Invoke("SpawnPlayer", 2f + animationDelay);
            Invoke("DoorClose", 3f + animationDelay);
            triggerEnter = true;
        }
    }

    private void SpawnPlayer()
    {
        Player = Instantiate(Player, new Vector3(playerSpawningPosition.position.x, );
        Player.transform.position = playerSpawningPosition.position;

    }
    private void DoorOpen()
    {
        door.GetComponent<SpriteRenderer>().sprite = openedDoor;
    }
    private void DoorClose()
    {
        door.GetComponent<SpriteRenderer>().sprite = closedDoor;
    }
}
