using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float MoveSpeed = 3;
    private float horizontal;
    private float vertical;

    public float jumpVelocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");  //��ȡˮƽ�������
        float v = Input.GetAxis("Vertical");    //��ȡ���������

        Vector2 position = transform.position;    //����һ����ά����
        position.x = position.x + MoveSpeed * h * Time.deltaTime;  //���±���
        position.y = position.y + MoveSpeed * v * Time.deltaTime;  //���±���

        transform.position = position;  //��ֵ���±���
    }
}
