using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{

    [SerializeField]
    public float speed = 2f;

    [SerializeField]
    public int health = 3;

    [SerializeField]
    public int damage = 1;
    
    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    Transform gunObject;
    float shootTimer = 0;

    [SerializeField]
    float timeBetweenShots = 0.5f;
    void Start()
    {
        
    }
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

       transform.Translate(Vector2.left * speed * Time.deltaTime);
    
    //Start is called before the first frame update

    // Update is called once per frame
    }
    
    }
