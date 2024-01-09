using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Camera pe fiecare stage
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    
    private float lookAhead;

    private void Update()
    {
        //Schimbarea camerei atunci cand se intra in alt stage
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }
}