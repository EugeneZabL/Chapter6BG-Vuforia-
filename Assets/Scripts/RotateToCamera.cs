using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour
{
    public void RotatePlaneToCamera()
    {
        // �������� ������ ����������� �� ������� � ������
        Vector3 direction = Camera.main.transform.position - transform.position;

        // �������� ���������� �� ���� X � Z, ����� �������� ������ �������� �� ��� Y
        direction.y = 0;

        // ���������, ����� direction �� ��� �������, ����� �������� ������
        if (direction != Vector3.zero)
        {
            // ��������� �������, ����������� ��� ����, ����� ������ ������� �� ������
            Quaternion rotation = Quaternion.LookRotation(direction);

            // ��������� ������� � �������
            transform.rotation = rotation;
        }
    }
}
