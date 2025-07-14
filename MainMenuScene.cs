using System;

namespace carrotTextRPG;

class MainMenuScene : SceneLoader
{
    public override void LoadScene()
    {
        while (true)
        {
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.\n이제 전투를 시작할 수 있습니다.\n\n0. 종료 \n1. 상태 보기\n2. 전투 시작\n\n원하시는 행동을 입력해주세요.\n>>");
            string input = Console.ReadLine();
            int inputInt;

            if (int.TryParse(input, out inputInt) == false)
            {
                ShowErrorMsg();
                continue;
            }

            if (inputInt == 0) return;

            else if (inputInt == 1)
            {
                SceneLoader statusScene = new StatusScene(); 
                statusScene.LoadScene(); 
            }
            
            else if (inputInt == 2) 
            {
                SceneLoader battleScene = new BattleScene();
                BeginBattle(); 
            }
            else ShowErrorMsg();
        }
    }

    private void ShowErrorMsg()
    {
        Console.WriteLine("잘못된 입력. 다시 시도하세요.");
    }
}