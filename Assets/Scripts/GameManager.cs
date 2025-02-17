using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalCollectibles = 5; // Set how many you need to collect to open the door
    private int collectiblesCollected = 0;
    public DoorController door;

    public void CollectiblePicked()
    {
        collectiblesCollected++;
        if (collectiblesCollected >= totalCollectibles)
        {
            door.ToggleDoor(); // Open the door when threshold reached
        }
    }
}
