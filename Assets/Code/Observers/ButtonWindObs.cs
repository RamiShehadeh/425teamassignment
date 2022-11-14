using UnityEngine;
using TMPro;

namespace Wx
{
    public class ButtonWindObs : MonoBehaviour
    {
        public Wind wind;
        [SerializeField]
        TextMeshPro tmp;
        string id;

        void Start()
        {
            // Add code to obtain reports of state changes.
            wind.ReportState += ReportState;
        }

        private void ReportState(bool isSimulated)
        {
            if (isSimulated) {
                tmp.text = "net";
                isSimulated = false;
            }
            else {
                tmp.text = "sim";
                isSimulated = true;
            }
            // Add code to manage reports of state changes.
        }
    }
}