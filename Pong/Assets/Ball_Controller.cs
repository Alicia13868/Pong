using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    public GameObject bat_1;
    public GameObject bat_2;

    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        Count_Score.canAddScore = true;
        StartCoroutine(Pause());
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) >= 21f)
        {
            Count_Score.canAddScore = true;

            transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
    }

    IEnumerator Pause()
    {
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);

        if (directionX == 0)
        {
            directionX = 1;
        }

        rigidbody2D.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        rigidbody2D.velocity = new Vector2(12f * directionX, 10f * directionY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bat_1")
        {
            if (bat_1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {

                rigidbody2D.velocity = new Vector2(10f, 10f);
            }
            else if (bat_1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rigidbody2D.velocity = new Vector2(10f, -10f);
            }
            else
            {
                rigidbody2D.velocity = new Vector2(12f, 0f);
            }
        }
        if (collision.gameObject.name == "Bat_2")
        {
            if (bat_2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {

                rigidbody2D.velocity = new Vector2(-10f, 10f);
            }
            else if (bat_2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rigidbody2D.velocity = new Vector2(-10f, -10f);
            }
            else
            {
                rigidbody2D.velocity = new Vector2(-12f, 0f);
            }
        }
    }
}
