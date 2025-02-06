using System.Xml.Linq;
using static MyTextRPG.Character;

namespace MyTextRPG
{
    
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleUtile.GetSceneNumber(1);
            GameManager gm = new GameManager();
        }
    }
    public class GameManager  // GameManager안에 사용되는 로직함수들을 넣고 Main함수에서는 GameManager 인스턴스만 실행
                       //  
    {
        Character character;
        List<Item> shopList = new List<Item>();
        List<Item> inventoryList = new List<Item>();
        public GameManager()
        {
            character = new Character("Unknown", 1, 100, character.Gold);
            ConsoleUtile.GetSceneNumber(0);
        }
        public void BeforeStart()
        {
            Thread.Sleep(75);
            Console.WriteLine("...");
        }
        public void StartScene()
        {
            Console.WriteLine("Dong'School에 오신 학생! 환영합니다");
            Console.WriteLine("Teacher : 학생 이름이 뭔가요? \n");
            Console.Write(">>");

            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name)) // IsNullOrEmpty 메서드는 bool값형태로
                                            // 매개변수 name에 string값이 비어있거나 없을때 사용됨,
            {
                StartScene();
                return;
            }

            name = character.Name;
            Console.WriteLine($"\nTeacher :  {character.Name} 맞나요? ");
            Console.WriteLine("\n1. 맞아요!");
            Console.WriteLine("0. 아닌데요..");
            int number = ConsoleUtile.GetNumber(0, 1);
            switch (number)
            {
                case 0:
                    StartScene();
                    break;
                case 1:
                    break;
            }
        } //시작화면 구현
        public void SelectScene()
        {
            Console.WriteLine("Teacher : 어떤 학생이고 싶어요?!");
            Console.WriteLine("1.반장");
            Console.WriteLine("2.부반장");
            Console.WriteLine("3.환경부장");
            Console.WriteLine("4.오락부장");
            Console.WriteLine("5.체육부장");
            Console.WriteLine("\n0. 돌아갈래요ㅠㅠ");
            int number = ConsoleUtile.GetNumber(1, 5);
            JobType jobType = JobType.반장; // 일단 변수를 받기 위해서 처음을 반장으로 초기화하고
            switch (number)
            {
                case 0:
                    StartScene();
                    break;
                case 1:
                    jobType = JobType.반장;
                    break;
                case 2:
                    jobType = JobType.부반장;
                    break;
                case 3:
                    jobType = JobType.환경부장;
                    break;
                case 4:
                    jobType = JobType.오락부장;
                    break;
                case 5:
                    jobType = JobType.체육부장;
                    break;
            } //직업선택 입력문

        }// 직업선택 창
        public void MainScene() 
        {
            Console.WriteLine("[Dong'School 복도]");
            Console.WriteLine("Teacher : 학생 이름이 뭔가요? \n");
            Console.Write(">>");
        }
    }

}