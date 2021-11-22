using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Szoba kamera
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    //játékosunk követő
    [SerializeField] private Transform player;

    private void Update()
    {
        //szoba kamera
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);

        //Játékosunk követése
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }
}
