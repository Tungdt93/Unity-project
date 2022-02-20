using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private int rotation;
    public float Speed;
    public GameObject GameObject;
    private List<GameObject> GameObjects = new List<GameObject>();
    private int score;
    private int move = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        transform.localRotation = Quaternion.Euler(0,rotation,0);
        if(Input.GetKey(KeyCode.LeftArrow) || move == 0)
        {
            rotation = -90;
        }
        else if (Input.GetKey(KeyCode.RightArrow )|| move == 1)
        {
            rotation = 90;
        }else if (Input.GetKey(KeyCode.DownArrow)|| move == 3)
        {
            rotation = 180;
        }
        else if (Input.GetKey(KeyCode.UpArrow)|| move == 2)
        {
            rotation = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("OBS"))
        {
            Destroy(collision.collider.transform.gameObject);
            score++;
            GameObject OBJ =  Instantiate(GameObject, new Vector3(transform.position.x,2,transform.position.z), Quaternion.identity,transform);
            GameObjects.Add(OBJ);
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObjects[i].transform.position = new Vector3(transform.position.x, 1 + transform.position.y *i *0.2f, transform.position.z);
            }
        }

        if (collision.collider.gameObject.CompareTag("Goal") && score > 8)
        {
            for (int i =4; i < GameObjects.Count ; i++)
            {
                Destroy(GameObjects[i].transform.gameObject);
                GameObjects.Remove(GameObjects[i]);
            }
            Destroy(collision.collider.transform.gameObject);
            //Bridge.SetActive(true);
        }

        if (collision.collider.gameObject.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(3);
        }

        if (collision.collider.gameObject.CompareTag("Death"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }

    public void left()
    {
        move = 0;
    }

    public void right()
    {
        move = 1;
    }

    public void foward()
    {
        move = 2;
    }

    public void back()
    {
        move = 3;
    }
}
