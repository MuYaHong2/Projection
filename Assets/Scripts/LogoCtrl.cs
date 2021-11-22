using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LogoCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var image = GetComponent<Image>();
        image.DOFade(1, 2).SetDelay(0.1f).OnComplete(()=> { image.DOFade(0, 2); });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

