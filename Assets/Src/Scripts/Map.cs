using System.Collections;
using UnityEngine;

namespace YsoCorp {

    public class Map : YCBehaviour {

        public Transform playerPos;
        private float baseSpeed = 0.1f;

        protected override void Awake() {
            base.Awake();
            this.game.menuHome.levelIndex.text = "Level " + this.resourcesManager.GetMapNumber();
        }

        public Transform GetStartingPos() {
            return this.playerPos;
        }

        public void LaunchMap(string config)
        {
            string[] obs = config.Split(';');
            float speed = obs.Length * baseSpeed;

            Debug.Log("start map");
            Debug.Log(config);
            StartCoroutine(SpawnObs(obs, speed));
        }

        IEnumerator SpawnObs(string[] obs, float speed)
        {
            for (int i = 0 ; i < obs.Length ; i++) {
                GetComponent<GenerateObstacles>().GenerateObstacleFromString(obs[i], speed);
                yield return new WaitForSeconds(5 / obs.Length);
            }
        }

    }

}
