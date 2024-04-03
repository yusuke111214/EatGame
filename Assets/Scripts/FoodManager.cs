using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class FoodManager : MonoBehaviour
{    
    Color[] colors = { Color.white, Color.red, Color.green, Color.blue, Color.cyan, Color.yellow, Color.magenta }; //色を配列で管理
    private RectTransform RectTransform_get;
    private void Awake()
    {
        RectTransform_get = gameObject.GetComponent<RectTransform>();
        GetComponent<Renderer>().material.color = colors[Random.Range(0, 7)]; // 色の配列からランダムにCubeの色を選択
    }


    private void Update()
    {
        Vector3 pos = RectTransform_get.position;
        
        if (pos.x < -16)
        {
            pos.x = 15;
        }
        
        
        RectTransform_get.position = pos;
        
    } 


}
