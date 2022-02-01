using UnityEngine;

namespace YsoCorp {

    [DefaultExecutionOrder(-1)]
    public class ResourcesManager : AResourcesManager {

        public Map forceMap;

        private Map[] _maps;
        private TextAsset _config;

        protected override void Awake() {
            base.Awake();
            this._maps = this.LoadIterator<Map>("Maps/Map");
            this._config = this.Load<TextAsset>("Config/lvl");
        }

        public int GetMapNumber() {
            int level = this.dataManager.GetLevel();
            return level;
        }

        public Map GetMap() {
#if UNITY_EDITOR
            if (this.forceMap != null) {
                return this.forceMap;
            }
#endif
            return this._maps[Random.Range(0, this._maps.Length)];
        }

        public string GetConfig()
        {
            int level = this.dataManager.GetLevel() - 1;
            string[] str = _config.text.Split('\n');

            return str[level];
        }

    }

}