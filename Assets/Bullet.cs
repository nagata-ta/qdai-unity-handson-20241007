using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    /// <summary>
    /// 球のスピード
    /// </summary>
    public float speed = 1f;

    /// <summary>
    /// 弾が削除されるまでの時間
    /// </summary>
    private float timelimit = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 弾が前方に進み続けるように位置情報を変更
        var position = gameObject.transform.position;
        position += gameObject.transform.forward * speed * Time.deltaTime;
        gameObject.transform.position = position;

        // 削除される時間になるまでカウント
        timelimit -= Time.deltaTime;
        if (timelimit < 0f)
        {
            // 弾オブジェクトを削除
            Destroy(gameObject);
        }
    }
}