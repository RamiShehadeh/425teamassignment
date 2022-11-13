using UnityEngine;
using TMPro;

namespace Wx
{
    // Put this on the models that will detect clicks that
    // instruct the appropriate Wind object to change between
    // live data from the internet and simulated data.

    public class ButtonWindCtl : MonoBehaviour
    {
        //public Wind wind;
        [SerializeField]
        public TextMeshPro textMesh; 
        private bool isSim; 
    


        void Start() {
            isSim = true;
        }

        private void OnMouseDown()
        {
            //wind.ChangeState();
            if (isSim) {
                textMesh.text = "net";
                isSim = false;
            }
            else {
                textMesh.text = "sim";
                isSim = true;
            }
        }
    }
}