using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotateSpeed = 90f; //旋转速度

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //让物体绕着 Y 轴（上下方向）旋转
        // 90 * Time.deltaTime 意思是；每秒转 90度
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}
