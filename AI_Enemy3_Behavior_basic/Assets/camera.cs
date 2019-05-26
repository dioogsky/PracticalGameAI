using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public Transform playerTransform;//跟踪的对象
    private Vector3 offset;
    public float moveSpeed;

    // Use this for initialization
    void Start()
    {
        //         当前位置              物体的位置
        //offset = transform.position - playerTransform.position;//计算相对距离
    }

    // Update is called once per frame
    void Update()
    {   
        var newX = Mathf.Lerp(transform.position.x, playerTransform.transform.position.x, Time.deltaTime * moveSpeed);
        var newZ = Mathf.Lerp(transform.position.z, playerTransform.transform.position.z, Time.deltaTime * moveSpeed);
        var newVector3 = new Vector3(newX, transform.position.y, newZ);
        transform.position = newVector3;
       //transform.position = playerTransform.position + offset; //保持相对距离
    }

   

}
