using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    /// <summary>
    /// Boomオブジェクトが生成されている時間
    /// </summary>
    private float lifetime = 2f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 時間をカウントして、生成時間を経過するか確認
        lifetime -= Time.deltaTime;
        if (lifetime < 0f)
        {
            // 時間が超えたらBoomオブジェクトを削除
            Destroy(gameObject);
        }
    }
}
