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
            wind.ReportState += ReportState;
        }

        private void ReportState(bool isSimulated)
        {
            // Add code to manage reports of state changes.
            if (!isSimulated) {
                tmp.text = "net";
            }
            else {
                tmp.text = "sim";
            }
        }
    }
}