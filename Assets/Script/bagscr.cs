using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class bagscr : MonoBehaviour
{
    public float speed;
    public float end;
    public float start;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.smoothDeltaTime);

        if (transform.position.x <= end)
        {
            Vector2 pos = new Vector2(start,transform.position.y);
            transform.position = pos;
        }
    }
}
