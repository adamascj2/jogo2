using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolanocaminho : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     iTween.MoveTo(this.gameObject,iTween.Hash("path",iTweenPath.GetPath("caminhobola"),"time",5,"looptype","loop","orienttopath",true,"looktime",1,"easeType",iTween.EaseType.linear));   
    }

    // Update is called once per frame
    void Update()
    {
      if(Pertobola2.perto) iTween.Stop(this.gameObject);
    }
}
