using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] Animator Anim;
    [SerializeField] private Button Damage;
    [SerializeField] private TMP_Text TxtHp;

    [SerializeField] private int HP;
    [SerializeField] private bool IsHit;

    private void Start()
    {
        Anim = GetComponent<Animator>();
        BtnDamage();
    }

    private void Update()
    {
        EnemyState();
        UpdateTxtHP();
    }

    private void BtnDamage()
    {
        Damage.onClick.AddListener(() => EnemyAction());
    }

    private void EnemyState()
    {
        if (HP > 0 && !IsHit)
        {
            Anim.SetInteger("State", 0);
        }
        else if (IsHit)
        {
            Anim.SetInteger("State", 1);
            IsHit = false;
        }
        else if (HP <= 0)
        {
            Anim.SetInteger("State", 2);
        }
    }
    private void EnemyAction()
    {
        if (HP > 0)
        {
            IsHit = true;
            HP--;
            Anim.SetInteger("State", 1);
        }
    }
    private void UpdateTxtHP()
    {
        TxtHp.text = HP.ToString();
    }
}
