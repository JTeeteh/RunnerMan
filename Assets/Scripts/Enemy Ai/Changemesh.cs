using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changemesh : Traps
{
    public Mesh meshes;
    MeshFilter meh;

    // Start is called before the first frame update

    protected override void Start()
    {
        meh = GetComponent<MeshFilter>();
        base.Start();

    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Trigger()
    {
        meh.mesh = meshes;

    }
}