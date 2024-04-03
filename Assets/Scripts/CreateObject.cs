using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObjectCreater : MonoBehaviour
{
    Rigidbody rigidbody;
    BoxCollider boxCollider;
    Color[] colors = { Color.white, Color.red, Color.green, Color.blue, Color.cyan, Color.yellow, Color.magenta }; //色を配列で管理

    private Vector3 offset;

    void Start()
    {
        InvokeRepeating("CreateCube", 0, 2); //CreateCube関数を2秒間隔で呼ぶ
    }

    void CreateCube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube); //Cubeを生成
        cube.transform.position = new Vector3(10, 8, 0); // Cubeが生成される座標を(-10, 8, 0)に設定
        cube.GetComponent<Renderer>().material.color = colors[Random.Range(0, 7)]; // 色の配列からランダムにCubeの色を選択
        rigidbody = cube.AddComponent<Rigidbody>(); //CubeにRigidbodyをアタッチする
        //boxCollider2D = cube.AddComponent<BoxCollider2D>(); //cubeにBoxcollider2Dをアタッチする
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation; //オブジェクトの回転を防止
        Destroy(cube ,9f); //9秒後にオブジェクトを破壊

        

        /*void OnMouseDown()
        {
            offset = cube.transform.position - GetMouseWorldPos();
        }

        void OnMouseDrag()
        {
            transform.position = GetMouseWorldPos() + offset;
        }

         Vector3 GetMouseWorldPos()
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -Camera.main.transform.position.z;
            return Camera.main.ScreenToWorldPoint(mousePos);
        }*/

    }
}
