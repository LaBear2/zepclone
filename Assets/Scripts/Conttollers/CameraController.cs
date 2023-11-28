using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    public float cameraSpeed = 5.0f;
    private Vector3 targetPosition;
    public GameObject Player;

    private void Update()
    {
        if (Player.gameObject != null)
        {
            // this�� ī�޶� �ǹ� (z���� ī�޶��� �״�� ����)
            targetPosition.Set(Player.transform.position.x, Player.transform.position.y, this.transform.position.z);

            // vectorA -> B���� T�� �ӵ��� �̵�
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, cameraSpeed * Time.deltaTime);
        }
    }
}
