using Blazored.LocalStorage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGUOptimizationTool
{
    public class StateContainer
    {

        public event Action OnChange;

        public StateContainer(ISyncLocalStorageService localStorage)
        {
            var data =  localStorage.GetItemAsString("playerData");
            if(data != null)
            {
                var settings = new JsonSerializerSettings()
                {
                    ObjectCreationHandling = ObjectCreationHandling.Replace
                };
                PlayerData = JsonConvert.DeserializeObject<PlayerData>(data, settings);
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

        private PlayerData _playerData;
        public PlayerData PlayerData { get => _playerData; set { _playerData = value; NotifyStateChanged(); } }
    }
}
