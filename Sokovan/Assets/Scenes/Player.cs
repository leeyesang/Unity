using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    float speed = 10f;
    Rigidbody playerRigidbody;
    public GameManager gameManager;
  

    void Start()
    {   
        //inspector에서 보이지 않도록 하기 위하여 지정
        // Rigidbody를 찾아다님.
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (gameManager.isGameOver ==  true)
        {
            return;
        }


        //-1 ~ +1
        float inputX = Input.GetAxis("Horizontal"); //좌우
        float inputZ = Input.GetAxis("Vertical"); //상하
        float fallSpeed = playerRigidbody.velocity.y;

        //playerRigidbody.AddForce(inputX * speed, 0, inputZ * speed);
        //AddForce는 누적 즉 관성이 붙는다.

        Vector3 velocity = new Vector3(inputX, 0, inputZ);

        //(inputX * speed, 0, inputZ * speed);
        velocity = velocity * speed;
        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;
    }
}
