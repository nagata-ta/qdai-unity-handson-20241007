using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;

    private AudioSource bang;

    // Start is called before the first frame update
    void Start()
    {
        bang = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var position = gameObject.transform.position;
        position += gameObject.transform.forward * Input.GetAxis("Vertical") * 0.2f;
        gameObject.transform.position = position;

        gameObject.transform.Rotate(0f, Input.GetAxis("Horizontal") * 2f, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation, null);
            bang.Play();
        }
    }
}
