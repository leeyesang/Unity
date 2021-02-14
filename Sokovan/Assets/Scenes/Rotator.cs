using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    //초당 프레임 60....
    void Update()
    {
        //연속 회전
        //transform.Rotate(60, 60, 60);
        //화면을 60번 깜빡이면 (초당 60프레임) 1/60
        //화면을 200번 깜빡이면 (초당 200프레임) 1/200
        // 60/200 * 200 =60

        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);

        //Time. deltaTime은 화면이 한번 깜빡이는 시간 = 1 프레임
    }
}
