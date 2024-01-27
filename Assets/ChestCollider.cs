using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtPlatformer_VillageProps {
    public class ChestCollider : MonoBehaviour
    {
        // Start is called before the first frame update
        public Chest chestScript;
        void Start()
        {
            chestScript = GetComponentInParent<Chest>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("e")) {
                chestScript.Open();
            } else if (Input.GetKeyDown("q")) {
                chestScript.Close();
            }
        
        }
    }

}
