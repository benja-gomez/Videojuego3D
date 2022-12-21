using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    AnimatorStateInfo animStateInfo;

    private static int
        ANIMATOR_PARAM_CAN_ATTACK = Animator.StringToHash("CanAttack");

    NavMeshAgent nav;

    public float minDamage = 10;

    public float maxDamage = 100;

    private Animator anim;

    private float dist;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        dist = Vector3.Distance(target.position, nav.destination);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(nav.transform.position, nav.destination);

        if (dist < 2)
        {
            anim.SetBool(ANIMATOR_PARAM_CAN_ATTACK, true);
        }
        else
        {
            anim.SetBool(ANIMATOR_PARAM_CAN_ATTACK, false);
        }
    }
}
