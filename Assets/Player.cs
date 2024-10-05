using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// bullet Prefab
    /// </summary>
    public GameObject bullet;

    /// <summary>
    /// 爆発音
    /// </summary>
    private AudioSource bang;

    // Start is called before the first frame update
    void Start()
    {
        // 爆発音を設定しているAudioSourceコンポーネントの情報を取得する（GetComponent）
        // public で参照を持たせるのと同じ
        bang = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // 上下のキーボード入力で Player の位置を移動させる
        // ※ gameObject = 現在のコンポーネント（Player）がアタッチされているゲームオブジェクト。今回の例だとPlayer.csをアタッチしているPlayerオブジェクト。
        var position = gameObject.transform.position;
        position += gameObject.transform.forward * Input.GetAxis("Vertical") * 0.1f;
        gameObject.transform.position = position;

        // 左右のキーボード入力で Player の角度を変更する
        gameObject.transform.Rotate(0f, Input.GetAxis("Horizontal") * 1f, 0f);

        // スペースキーを入力したら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 弾（bullet Prefab）を生成
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation, null);
            // 弾発射の音を鳴らす
            bang.Play();
        }
    }
}
