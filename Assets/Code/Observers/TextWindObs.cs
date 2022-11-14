using UnityEngine;
using TMPro;

namespace Wx
{
    public class TextWindObs : MonoBehaviour
    {
        public Wind wind;

        TextMeshPro tmp;

        void Start()
        {
            // Add code to obtain reports of state changes.
            wind.ReportWind += ReportWind;
        }

        void ReportWind(float d, float s)
        {
            // Add code to manage reports of state changes.
            if (d > 157.5f && d <= 202.5f)
                tmp.text = "S \n" + s;
            else if (d > 202.5f && d <= 247.5f)
                tmp.text = "SW \n" + s;
            else if (d > 247.5f && d <= 292.5f)
                tmp.text = "W \n" + s;
            else if (d > 292.5f && d <= 337.5f)
                tmp.text = "NW \n" + s;
            else if (d > 337.5f && d <= 360f)
                tmp.text = "N \n" + s;
            else if (d >= 0f && d <= 22.5f)
                tmp.text = "N \n" + s;
            else if (d > 22.5f && d <= 67.5f)
                tmp.text = "NE \n" + s;
            else if (d > 67.5f && d <= 112.5f)
                tmp.text = "E \n" + s;
            else
                tmp.text = "SE \n" + s;

        }
    }
}