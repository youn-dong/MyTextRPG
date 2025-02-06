using System;
using static MyTextRPG.SceneManager;

public static class ConsoleUtile
{
    
    public static int GetNumber(int min, int max)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number) && (number >= min) && (number <= max)) //TryParse를 통해서 입력된 값에서 number라는 값형식 변수로 할당
            {
                Console.WriteLine("원하는 행동을 입력해주세요.");
                Console.Write(">>");
                return number;
            }
            else
            {
                Console.WriteLine($"잘못된 입력입니다. {min}에서 {max}사이로 입력해주세요.");
            }
        }
    }
    public static SceneNumber GetSceneNumber(int sceneNumber)
    {
        while (true)
        {
            switch (sceneNumber)
            {
                case 0:
                    return SceneNumber.BeforeStartScene;
                case 1:
                    return SceneNumber.StartScene;
                case 2:
                    return SceneNumber.MainScene;
                case 3:
                    return SceneNumber.StatusScene;
                case 4:
                    return SceneNumber.InventoryScene;
                case 5:
                    return SceneNumber.ShopScene;
                case 6:
                    return SceneNumber.RestScene;
                case 7:
                    return SceneNumber.DungeonScene;
                default:
                    Console.WriteLine("숫자를 잘못 입력하셨습니다. 다시 입력해주세요.");
                    break;
            }
        }
    }

}

