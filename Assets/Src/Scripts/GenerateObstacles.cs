using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YsoCorp
{
    public class GenerateObstacles : YCBehaviour
    {
        [SerializeField] Vector3 obsSwpanPos;
        [SerializeField] GameObject emptyObstacles;
        [SerializeField] Texture[] shapes;
        [SerializeField] Color[] colors;

        public void GenerateObstacleFromString(string obstacle, float speed)
        {
            GameObject newObj = Instantiate(emptyObstacles, obsSwpanPos, Quaternion.identity);
            newObj.GetComponentInChildren<RawImage>().texture = shapes[obstacle[0]];
            newObj.GetComponentInChildren<RawImage>().color = colors[obstacle[1]];
            newObj.GetComponent<MoveObs>().SetSpeed(speed);
        }
    }
}