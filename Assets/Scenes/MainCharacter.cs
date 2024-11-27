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
        float h = Input.GetAxis("Horizontal");  //获取水平轴的输入
        float v = Input.GetAxis("Vertical");    //获取纵轴的输入

        Vector2 position = transform.position;    //创建一个二维变量
        position.x = position.x + MoveSpeed * h * Time.deltaTime;  //更新变量
        position.y = position.y + MoveSpeed * v * Time.deltaTime;  //更新变量

        transform.position = position;  //赋值更新变量
    }
}
