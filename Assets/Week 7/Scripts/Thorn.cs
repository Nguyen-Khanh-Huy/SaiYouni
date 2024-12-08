using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class Thorn : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Button _btnActiveThorn;
    [SerializeField] private TextMeshProUGUI _txtTimeThornActive;
    [SerializeField] private GameObject _itemSpeed;

    public float TimeThornActive;
    public float Damage;
    [SerializeField] private bool _isActive;
    
    private void Start()
    {
        _btnActiveThorn.onClick.AddListener(() => _isActive = true);
    }

    private void Update()
    {
        ActiveThorn();
        _txtTimeThornActive.text = "Curent Time Thorn Activate: " + TimeThornActive.ToString();
    }
    private void ActiveThorn()
    {
        if (_isActive)
        {
            TimeThornActive -= Time.deltaTime;
            if (TimeThornActive <= 0f)
            {
                _rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
                _isActive = false;
                TimeThornActive = _itemSpeed.activeSelf ? 3f : 2f;
            }
        }
    }
}
