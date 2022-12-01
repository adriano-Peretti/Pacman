using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform ExitPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = ExitPosition.position;
    }
}
