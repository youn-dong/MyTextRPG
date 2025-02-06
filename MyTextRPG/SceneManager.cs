using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyTextRPG
{
    public  class SceneManager
    {
        private SceneManager() { } // private 생성자를 통한 외부에서 객체생성불가상태로

        private static readonly  Lazy<SceneManager> instance = new Lazy<SceneManager>(); // 해당 부분이 System.Lazy<T>를 
                                                                                         // 이용한 싱글톤패턴
        public static SceneManager Instance { get { return instance.Value; } } 
        
        public enum SceneNumber
        {
            BeforeStartScene,
            StartScene,
            MainScene,
            StatusScene,
            InventoryScene,
            ShopScene,
            RestScene,
            DungeonScene
        }
    }
}
