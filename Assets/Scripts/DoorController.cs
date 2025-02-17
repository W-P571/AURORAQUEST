using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool isOpen = false;
    public float openSpeed = 2f;
    public Vector3 openPositionOffset = new Vector3(0, 0, -3);

    private Vector3 closedPosition;

    void Start()
    {
        closedPosition = transform.position;
    }

    void Update()
    {
        if (isOpen)
        {
            // Slide door to open position
            transform.position = Vector3.Lerp(transform.position, closedPosition + openPositionOffset, Time.deltaTime * openSpeed);
        }
        else
        {
            // Ensure door stays in closed position
            transform.position = Vector3.Lerp(transform.position, closedPosition, Time.deltaTime * openSpeed);
        }
    }

    // This method can be called when a condition (like collecting items) is met.
    public void ToggleDoor()
    {
        isOpen = !isOpen;
    }
}
