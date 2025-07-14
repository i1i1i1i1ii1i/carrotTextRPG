using System;

namespace carrotTextRPG;

class MainMenuScene : SceneLoader
{
    public override void LoadScene()
    {
        while (true)
        {
            Console.WriteLine("���ĸ�Ÿ ������ ���� ������ ȯ���մϴ�.\n���� ������ ������ �� �ֽ��ϴ�.\n\n0. ���� \n1. ���� ����\n2. ���� ����\n\n���Ͻô� �ൿ�� �Է����ּ���.\n>>");
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
        Console.WriteLine("�߸��� �Է�. �ٽ� �õ��ϼ���.");
    }
}