using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 爆発エフェクト
    /// </summary>
    public GameObject boom;

    /// <summary>
    /// ゲーム管理マネージャー
    /// </summary>
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // Enemyオブジェクトにぶつかったオブジェクトのタグが "Bullet" だった場合 
        if (other.gameObject.tag.Equals("Bullet"))
        {
            Debug.Log("衝突したよ");
            // 爆発エフェクトを生成
            Instantiate(boom, gameObject.transform.position, Quaternion.identity, null);
            // other（ = 弾オブジェクト）を削除する
            Destroy(other.gameObject);
            // gameObject（ = Enemyオブジェクト）を削除する
            Destroy(gameObject);

            // スコア追加の処理を実行
            gameManager.AddScore(100);
        }
    }
}
