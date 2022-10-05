using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BzKovSoft.ObjectSlicer;
using BzKovSoft.ObjectSlicer.Samples;
using DG.Tweening;
public class Slicer : MonoBehaviour
{
    [SerializeField] private GameObject _blade;
    [SerializeField] private float _duration;
    [SerializeField] private float _posOffsetY;
    [SerializeField] private float _rotOffsetZ;
    [SerializeField] private float _sliceDelay;
    private float _timeAfterSlice;

    private BzKnife _knife;

    private void Start()
    {
        _knife = _blade.GetComponentInChildren<BzKnife>();
    }

    private void Update()
    {
        _timeAfterSlice += Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if (_timeAfterSlice > _sliceDelay)
            {
                _knife.BeginNewSlice();
                _blade.transform.DOMoveY(_blade.transform.position.y - _posOffsetY, _duration).SetLoops(2, LoopType.Yoyo);
                _blade.transform.DORotate(new Vector3(_blade.transform.rotation.x, _blade.transform.rotation.y, _blade.transform.rotation.z + _rotOffsetZ), _duration).SetLoops(2, LoopType.Yoyo);
                _timeAfterSlice = 0;
            }
                
        }
    }

}
