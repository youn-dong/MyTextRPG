using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MyTextRPG
{
    public class Character
    {
        public enum JobType
        {
            반장  = 0,
            부반장 = 1,
            환경부장 =2,
            오락부장 =3,
            체육부장 =4
        }
        public JobType jobType; //항상 enum을 만들고 나면 프로퍼티를 통해서 생성할 수 있어야 한다.
        public int Level { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Power { get; set; }
        public int Defense { get; set; }
        public int Gold { get; set; }
        public int MaxHp { get; set; }
        public string Des {  get; set; }

        public Character(string name, int lv, int Hp, int gold)
        {
            name = Name;
            lv = Level;
            int maxHp = MaxHp;
            Hp = 100;
            gold = Gold;
            switch (jobType)  //enum이면 변수명.열거항목 
                              //JobType.반장 ...etc
            {
                case JobType.반장:
                    Power = 5;
                    Defense = 8;
                    Gold = 1500;
                    Des = "원래 반장은 힘이 없습니다.";
                    break;
                case JobType.부반장:
                    Power = 6;
                    Defense = 5;
                    Gold = 5000;
                    Des = "원래 돈이 많은 학생이 부반장을 합니다.";
                    break;
                case JobType.환경부장:
                    Power = 7;
                    Defense = 8;
                    Gold = 1500;
                    Des = "원래 뭐든 잘하는 학생이 환경부장을 합니다.";
                    break;
                case JobType.오락부장:
                    Power = 8;
                    Defense = 6;
                    Gold = 1500;
                    Des = "원래 인기많은 학생이 오락부장을 합니다.";
                    break;
                case JobType.체육부장:
                    Power = 10;
                    Defense = 5;
                    Gold = 5000;
                    Des = "원래 힘이 많은 학생이 체육부장을 합니다.";
                    break;
            }
        }

    }

}
