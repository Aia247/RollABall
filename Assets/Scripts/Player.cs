using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    public Rigidbody rd;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    public GameObject  winText;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("游戏开始");
        // rd = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // right,left,forward,back Vector3.right
        // (5,0,0) new Vector3(5,0,0)
        // rd.AddForce(Vector3.right);
        
        // Horizontal 水平 -1,1
        float h = Input.GetAxis("Horizontal");
        // Vertical   垂直 -1,1
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v));
        // Debug.Log("游戏运行中");
    }

    // -----------------------触发检测----------------------- //

    private void OnTriggerEnter(Collider other) {
        // Debug.Log("触发发生执行" + other.tag);
        if (other.tag == "Food")
        {
            Destroy(other.gameObject);

            score++;

            scoreText.text = "score: " + score ;

            if (score == 10)
            {
                winText.SetActive(true);
            }
        }


    }

    // private void OnTriggerExit(Collider other) {
    //     Debug.Log("触发结束执行" + other.tag);
    // }

    // private void OnTriggerStay(Collider other) {
    //     Debug.Log("触发时一直执行");
    // }

    // ----------------------------------------------------- //




    // // -----------------------碰撞检测----------------------- //
    // private void OnCollisionEnter(Collision collision) {
    //     // Debug.Log("碰撞发生执行");

    //     // collection.collider.tag 组件获取

    //     if (collection.gameObject.tag == "Food")
    //     {
    //         // 销毁食物
    //         Destroy(collection.gameObject);
    //     }
    // }

    // private void OnCollisionExit(Collision collistion) {
    //     // Debug.Log("碰撞结束执行");
    // }

    // private void OnCollisionStay(Collision collection) {
    //     // Debug.Log("碰撞时一直执行");
    // }
    // ----------------------------------------------------- //
}
