using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextRPG
{
    public enum ItemType
    {
        Weapon,
        Shield,
        Potion
    }
    public class Item
    {
        string Name { get; set; }
        int Power { get; set; }
        int Defense { get; set; }
        string Des { get; set; }
        int Price { get; set; }
        public ItemType Type { get; set; }
        int Health { get; set; }

        public Item(string name) //항상 생성자는 class안에 넣기.
        {
            Name = name;
            switch (Type)

            {
                case ItemType.Weapon:
                    Price = 5000;
                    Power = 30;
                    Defense = 0;
                    Des = "무기";
                    break;
                case ItemType.Shield:
                    Price = 5000;
                    Power = 0;
                    Defense = 30;
                    Des = "방어구";
                    break;
                case ItemType.Potion:
                    Price = 5000;
                    Health = 50;
                    Des = "포션";
                    break;


            }
        }
    }
}
