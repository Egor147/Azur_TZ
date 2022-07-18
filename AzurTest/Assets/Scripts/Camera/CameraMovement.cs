using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private GameObject player;

    [Header(" ")]
    [SerializeField]private float Offset;

    private void FixedUpdate() => CameraMove();

    private void CameraMove()
    {
        float positionToGo = player.transform.position.z - Offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position,new Vector3(transform.position.x, transform.position.y,positionToGo), 0.125f);
        transform.position = smoothPosition;
    }
}
