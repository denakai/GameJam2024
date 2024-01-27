using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    
    
    [SerializeField] private Vector3 offset = new Vector3(0f, 2f, -10f);
    private float smoothTime = .25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform playerTarget;
    [SerializeField] private Transform mainMenuTarget;

    private Transform currentTarget;

    void Start() {
        currentTarget = mainMenuTarget;
        transform.position = mainMenuTarget.position + offset;
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = currentTarget.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

    public void switchTarget() {
        if (currentTarget == playerTarget) {
            currentTarget = mainMenuTarget;
        } else {
            currentTarget = playerTarget;
        }
    }
}
