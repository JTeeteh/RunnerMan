using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPassTrap : Traps
{
        public Material material;
        Renderer rend;

        // Start is called before the first frame update

        protected override void Start()
        {
            base.Start();
            rend = GetComponent<Renderer>();
            rend.enabled = true;
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }

        protected override void Trigger()
        {

            rend.sharedMaterial = material;
            GetComponent<BoxCollider>().enabled = false;
        }
}