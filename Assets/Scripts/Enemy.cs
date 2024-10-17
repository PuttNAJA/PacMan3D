using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    public Transform homePoint;
    public bool chasing, inHome;
    public float inHomeSight;
    public LayerMask home;
    public SceneLoader scene;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        chasing = true;
    }
    public void Update()
    {
        inHome = Physics.CheckSphere(transform.position, inHomeSight, home);

        if (chasing) Chase();
        if (!chasing) Escape();
        if (!chasing && inHome) 
        {
            Chase();
            chasing = true;
        }

        
    }

    public void Escape()
    {
        Vector3 distancePlayer = player.position - transform.position;


        enemy.SetDestination(homePoint.position);
        if (distancePlayer.magnitude <= 4)
        { 
            Destroy(gameObject);
            ScoreManager.scoreCount += 10;
            audioManager.PlaySound(audioManager.Ghost);
        }
    }
    public void Chase()
    {
        Vector3 distancePlayer = transform.position - player.position;

        enemy.SetDestination(player.position);
        if (distancePlayer.magnitude <= 4)
        {
            scene.ToOver();
        }
    }
}
