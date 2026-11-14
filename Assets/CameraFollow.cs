using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //你要跟谁走？ (等下把小球拖进来）
    public Transform target;

    //相机和小球的距离（偏移量）
    public Vector3 offest = new Vector3(0f, 5f, -5f);

    //注意！相机通常跟谁通常用 LaUpdate，这样最顺乎
    void LateUpdate()
    {
        
        if (target !=null)
            {


            //相机的位置 =目标的位置 + 偏移位
            transform.position = target.position + offest;


        }

    }



}

