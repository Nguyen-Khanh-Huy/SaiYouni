using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Thorn _thorn;

    [SerializeField] private GameObject _vfxIncreaseDamage;
    [SerializeField] private GameObject _vfxIncreaseSpeed;
    [SerializeField] private GameObject _vfxIncreaseRange;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ItemDamage"))
        {
            _thorn.Damage += 1f;
            StartCoroutine(UnactiveVFX(collision.gameObject, _vfxIncreaseDamage));
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("ItemSpeed"))
        {
            _thorn.TimeThornActive -= 1f;
            StartCoroutine(UnactiveVFX(collision.gameObject, _vfxIncreaseSpeed));
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("ItemRange"))
        {
            _thorn.transform.localScale = new Vector3(_thorn.transform.localScale.x, _thorn.transform.localScale.y + 1, _thorn.transform.localScale.z + 1);
            StartCoroutine(UnactiveVFX(collision.gameObject, _vfxIncreaseRange));
        }
    }
    private IEnumerator UnactiveVFX(GameObject objItem, GameObject objVFX)
    {
        objItem.SetActive(false);
        var newVFX = Instantiate(objVFX, _thorn.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        newVFX.SetActive(false);
    }
}
