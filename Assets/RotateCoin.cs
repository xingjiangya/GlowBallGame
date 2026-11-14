using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //让金币绕着Y轴（上下方向）每秒90度
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);

        
    }
}
