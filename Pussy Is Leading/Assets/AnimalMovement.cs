using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed;
    public float delay;
    public bool onTheWay;
    public int currentZone;
    public int nextZone;
    Vector2 currentPosition;
    Vector2 nextPosition;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1.0f;
        onTheWay = false;
        currentZone = 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = new Vector2(transform.position.x, transform.position.y);

        if (currentPosition == nextPosition)
        {
            delay -= Time.deltaTime;
            if (delay < 0)
            {
                onTheWay = false;
            }
        }

        if (onTheWay == false)
        {
            delay = Random.Range(2.0f, 4.0f);
            onTheWay = true;
            if (currentZone == 1)
            {
                //1 2
                nextZone = Random.Range(0, 2);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-2.5f, -0.5f);
                    nextPosition.y = Random.Range(1.5f, 2.5f);
                    currentZone = 1;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(0.4f, 0.7f);
                    currentZone = 2;
                }
            }
            else if (currentZone == 2)
            {
                //1 2 3 4 5
                nextZone = Random.Range(0, 5);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-2.5f, -0.5f);
                    nextPosition.y = Random.Range(1.5f, 2.5f);
                    currentZone = 1;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(0.4f, 0.7f);
                    currentZone = 2;
                }
                if (nextZone == 2)
                {
                    nextPosition.x = Random.Range(0.4f, 0.6f);
                    nextPosition.y = Random.Range(0.9f, 1.5f);
                    currentZone = 3;
                }
                if (nextZone == 3)
                {
                    nextPosition.x = Random.Range(-3.8f, -3.2f);
                    nextPosition.y = Random.Range(0.5f, 1.5f);
                    currentZone = 4;
                }
                if (nextZone == 4)
                {
                    nextPosition.x = Random.Range(-2.0f, 0.5f);
                    nextPosition.y = Random.Range(-0.7f, 0.0f);
                    currentZone = 5;
                }
            }
            else if (currentZone == 3)
            {
                //2 3
                nextZone = Random.Range(0, 2);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(0.4f, 0.7f);
                    currentZone = 2;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(0.4f, 0.6f);
                    nextPosition.y = Random.Range(0.9f, 1.5f);
                    currentZone = 3;
                }
            }
            else if (currentZone == 4)
            {
                //2 4
                nextZone = Random.Range(0, 2);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(0.4f, 0.7f);
                    currentZone = 2;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(-3.8f, -3.2f);
                    nextPosition.y = Random.Range(0.5f, 1.5f);
                    currentZone = 4;
                }
            }
            else if (currentZone == 5)
            {
                //2 5 6 7
                nextZone = Random.Range(0, 4);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(0.4f, 0.7f);
                    currentZone = 2;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(-2.0f, 0.5f);
                    nextPosition.y = Random.Range(-0.7f, 0.0f);
                    currentZone = 5;
                }
                if (nextZone == 2)
                {
                    nextPosition.x = Random.Range(0.7f, 1.4f);
                    nextPosition.y = Random.Range(-0.7f, 0.6f);
                    currentZone = 6;
                }
                if (nextZone == 3)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(-1.7f, -1.4f);
                    currentZone = 7;
                }
            }
            else if (currentZone == 6)
            {
                //5 6
                nextZone = Random.Range(0, 2);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-2.0f, 0.5f);
                    nextPosition.y = Random.Range(-0.7f, 0.0f);
                    currentZone = 5;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(0.7f, 1.4f);
                    nextPosition.y = Random.Range(-0.7f, 0.6f);
                    currentZone = 6;
                }
            }
            else if (currentZone == 7)
            {
                //5 7 8 10
                nextZone = Random.Range(0, 4);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-2.0f, 0.5f);
                    nextPosition.y = Random.Range(-0.7f, 0.0f);
                    currentZone = 5;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(-1.7f, -1.4f);
                    currentZone = 7;
                }
                if (nextZone == 2)
                {
                    nextPosition.x = Random.Range(-6.0f, -3.0f);
                    nextPosition.y = Random.Range(-2.0f, -0.5f);
                    currentZone = 8;
                }
                if (nextZone == 3)
                {
                    nextPosition.x = Random.Range(-1.5f, 1.0f);
                    nextPosition.y = Random.Range(-2.7f, -2.3f);
                    currentZone = 10;
                }
            }
            else if (currentZone == 8)
            {
                //7 8 9
                nextZone = Random.Range(0, 3);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(-1.8f, -1.4f);
                    currentZone = 7;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(-6.0f, -3.0f);
                    nextPosition.y = Random.Range(-2.0f, -0.5f);
                    currentZone = 8;
                }
                if (nextZone == 2)
                {
                    nextPosition.x = Random.Range(-6.3f, -4.9f);
                    nextPosition.y = Random.Range(-0.5f, 0.5f);
                    currentZone = 9;
                }
            }
            else if (currentZone == 9)
            {
                //8 9
                nextZone = Random.Range(0, 2);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-6.0f, -3.0f);
                    nextPosition.y = Random.Range(-2.0f, -0.5f);
                    currentZone = 8;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(-6.3f, -4.9f);
                    nextPosition.y = Random.Range(-0.5f, 0.5f);
                    currentZone = 9;
                }
            }
            else if (currentZone == 10)
            {
                //7 10 11
                nextZone = Random.Range(0, 3);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-3.0f, -0.0f);
                    nextPosition.y = Random.Range(-1.7f, -1.4f);
                    currentZone = 7;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(-1.5f, 1.0f);
                    nextPosition.y = Random.Range(-2.7f, -2.3f);
                    currentZone = 10;
                }
                if (nextZone == 2)
                {
                    nextPosition.x = Random.Range(1.0f, 2.5f);
                    nextPosition.y = Random.Range(-2.5f, -1.5f);
                    currentZone = 11;
                }
            }
            else if (currentZone == 11)
            {
                //10 11
                nextZone = Random.Range(0, 2);
                if (nextZone == 0)
                {
                    nextPosition.x = Random.Range(-1.5f, 1.0f);
                    nextPosition.y = Random.Range(-2.7f, -2.3f);
                    currentZone = 10;
                }
                if (nextZone == 1)
                {
                    nextPosition.x = Random.Range(1.0f, 2.5f);
                    nextPosition.y = Random.Range(-2.5f, -1.5f);
                    currentZone = 11;
                }
            }
        }

        transform.position = Vector2.MoveTowards(currentPosition, nextPosition, moveSpeed * Time.deltaTime);

    }
}
