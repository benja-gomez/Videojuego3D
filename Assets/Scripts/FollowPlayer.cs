using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = gameObject.GetComponent<Animator>();

        float dist = Vector3.Distance(nav.transform.position, nav.destination);

        nav.SetDestination(target.position);
    }
}
