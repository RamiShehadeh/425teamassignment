using UnityEngine;
using TMPro;

namespace Wx
{
    public class TextWindObs : MonoBehaviour
    {
        public Wind wind;

        //TextMeshPro tmp;

        public TextMeshPro dir;
        public TextMeshPro speed;


        void Start()
        {
            // Add code to obtain reports of state changes.
            wind.ReportWind += ReportWind;
        }

        void ReportWind(float d, float s)
        {
           
            // Add code to manage reports of state changes.
            int windterval = (int)(((d + 22.5f) / 45.0f) % 8.0f);

            string directionName;
            switch (windterval)
            {
                case 0: directionName = "N"; break;
                case 1: directionName = "NE"; break;
                case 2: directionName = "E"; break;
                case 3: directionName = "SE"; break;
                case 4: directionName = "S"; break;
                case 5: directionName = "SW"; break;
                case 6: directionName = "W"; break;
                case 7: directionName = "NW"; break;
                default: directionName = "N/A"; break;
            }
            dir.text = directionName;

            speed.text = ((int)s).ToString();


            speed.text = ((int) s).ToString();


        }
    }
}