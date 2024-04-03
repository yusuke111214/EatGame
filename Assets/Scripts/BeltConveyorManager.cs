using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveyor : MonoBehaviour
{
    public float speed; //ベルトコンベアの速度

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red; //ベルトコンベアの色を赤にする
    }

    void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        rb.velocity = Vector3.right * speed; //ベルトコンベアに乗っているオブジェクトを(1, 0, 0)方向に移動させる
    }
}