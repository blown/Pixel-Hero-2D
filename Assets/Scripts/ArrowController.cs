using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private Rigidbody2D arrowRB;
    [SerializeField] private float arrowSpeed;
    private Vector2 _arrowDirection;
    public Vector2 ArrowDirection { get => _arrowDirection; set => _arrowDirection = value; }
    [SerializeField] private GameObject arrowImpact;
    private Transform transformArrow;
    [SerializeField] private GameObject batImpact;
    private GameObject batHit;

    private void Awake()
    {
        arrowRB= GetComponent<Rigidbody2D>();
        transformArrow= GetComponent<Transform>();
    }

    void Update()
    {
        arrowRB.velocity=ArrowDirection*arrowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bat"))
        {
            batHit = GameObject.Find(other.name);
            Instantiate(batImpact, transformArrow.position, Quaternion.identity);
            Destroy(batHit.gameObject);
        }
        else
            Instantiate(arrowImpact, transformArrow.position, Quaternion.identity);
            Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
