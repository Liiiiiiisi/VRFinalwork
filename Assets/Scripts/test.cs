using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float moveSpeed = 5f; //��ɫ�ƶ��ٶ�

    // Update is called once per frame
    void Update()
    {
        // ��ȡˮƽ�ʹ�ֱ���루ͨ���Ǽ�ͷ����WASD����
        float horizontal = Input.GetAxis("Horizontal"); // A/D �� ��/�Ҽ�ͷ
        float vertical = Input.GetAxis("Vertical"); // W/S �� ��/�¼�ͷ

        // �����ƶ���������������ƶ��ٶȺ�deltaTime��ʹ�ƶ�ƽ����֡�ʶ���
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // ���½�ɫλ��
        transform.Translate(movement);
    }
}
