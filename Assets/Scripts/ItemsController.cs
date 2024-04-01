using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ItemsController : MonoBehaviour
{

    public Vector3 targetPosition;
    public float offset = 2.0f;
    [SerializeField] public float speed;
    public bool canMoveAndFades = false;
    public SpriteRenderer spriteRenderer;
    public float elapsedTime;
    private Transform itemTransform;

    void Start()

    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        itemTransform = GetComponent<Transform>();
        targetPosition = new Vector3(itemTransform.position.x, itemTransform.position.y + offset, itemTransform.position.z);
        
    }

    void Update()

    {
        if (canMoveAndFades)
        {
            Move();
            Fade();
            elapsedTime += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canMoveAndFades=true;
        }
    }

    private void Move()

    {
        itemTransform.position = Vector3.Lerp(itemTransform.position, targetPosition, speed * Time.deltaTime);
        Debug.Log(targetPosition.y);
        Debug.Log(itemTransform.position.y);
        if (Math.Round(targetPosition.y, 2) == Math.Round(itemTransform.position.y, 2))
            Destroy(gameObject);
    }

    private void Fade()

    {
        spriteRenderer.color = new Color(1, 1, 1, Mathf.Lerp(1, 0, elapsedTime));
    }

}
