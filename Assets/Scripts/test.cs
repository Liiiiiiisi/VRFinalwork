using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float moveSpeed = 5f; //角色移动速度

    // Update is called once per frame
    void Update()
    {
        // 获取水平和垂直输入（通常是箭头键或WASD键）
        float horizontal = Input.GetAxis("Horizontal"); // A/D 或 左/右箭头
        float vertical = Input.GetAxis("Vertical"); // W/S 或 上/下箭头

        // 创建移动向量并将其乘以移动速度和deltaTime，使移动平滑且帧率独立
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // 更新角色位置
        transform.Translate(movement);
    }
}
