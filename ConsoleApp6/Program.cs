using System;
using System.Collections.Generic;
using System.Threading;

class Program
{


    class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Health { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int Gold { get; set; }
        public List<string> Inventory { get; set; }

        public Player(string name, string playerClass)d
        {
            Name = name;
            Class = playerClass;
            Health = 100;
            ATK = 10;
            DEF = 0;
            Gold = 50;
            Inventory = new List<string>();
        }

        public void ShowInfo()
        {
            int startX = 0;
            int startY = 18;
            int anotherX = 4;
            int anotherY = 20;

            Console.Clear();
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╔██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████╗");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                              ██                                                                                  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                              ██                                                                                  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                              ██                                                                                  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                              ██                                                                                  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                              ██                                                                                  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                              ██                                                                                  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                              ██                                                                                  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                              ██                                                                                  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(anotherX, anotherY++);
            Console.WriteLine($"ㆍ이름 :   {Name}");
            Console.SetCursorPosition(anotherX, anotherY++);
            Console.WriteLine($"ㆍ직업 :   {Class}");
            Console.SetCursorPosition(anotherX, anotherY++);
            Console.WriteLine($"ㆍ체력 :   {Health}");
            Console.SetCursorPosition(anotherX, anotherY++);
            Console.WriteLine($"ㆍ공격력 : {ATK}");
            Console.SetCursorPosition(anotherX, anotherY++);
            Console.WriteLine($"ㆍ방어력 : {DEF}");
            Console.SetCursorPosition(anotherX, anotherY++);
            Console.WriteLine($"ㆍ골드 :   {Gold}");
        } // 플레이어 정보
    }

    public class PlaySound
    {
        public void PlayEnterSound(int duration)
        {
            int[] EnterSound = { 1100, 1000, 1200 };         // 효과음2
            foreach (int frequency in EnterSound)
            {
                Console.Beep(frequency, duration);  // duration 동안 비프음 재생
            }
        }

        public void PlaySelectionSound(int duration)
        {
            int[] selectionSound = { 1000, 1500, 2000 };  // 효과음

            foreach (int frequency in selectionSound)
            {
                Console.Beep(frequency, duration);  // duration 동안 비프음 재생
            }
        }
    } //사운드

    static void Main(string[] args)
    {
        PlaySound PS = new PlaySound();

        Console.OutputEncoding = System.Text.Encoding.Unicode; // 폰트 인코딩

        Console.BackgroundColor = ConsoleColor.DarkGray;// 배경 색상 설정
        Console.ForegroundColor = ConsoleColor.Black; // 폰트 색상 설정

        Console.Clear();

        StartScreen(); // 게임 시작 화면 출력

        Player player = new Player("Rtan", "");

        SelectMyClass();

        void StartScreen()
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                             ╔██████╗╔███████╗╔██╗╔██╗╔██████╗   ╔██████╗ ╔██████╗╔██████╗ ");
            Console.WriteLine("                             ╚═╗██╔═╝║██╔════╝╚╗█║║█╔╝╚═╗██╔═╝   ║██  ██║ ║██  ██║║██╔═══╝ ");
            Console.WriteLine("                               ║██║  ║███████╗  ║██║    ║██║     ║██████║ ║██████║║██║╔███╗");
            Console.WriteLine("                               ║██║  ║██╔════╝ ╔█║║█╗   ║██║     ║██╔═╗██╗║██╔═══╝║██║╚╗██║");
            Console.WriteLine("                               ║██║  ║███████╗╔██║║██╗  ║██║     ║██║ ║██║║██║    ║███████║");
            Console.WriteLine("                               ╚══╝  ╚═══════╝╚══╝╚══╝  ╚══╝     ╚══╝ ╚══╝╚══╝    ╚═══════╝");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                Press any key to start");
            Console.ReadKey(true); // true를 넣어 키 입력을 화면에 표시하지 않도록 설정

            PS.PlaySelectionSound(500); // 소리 재생
        }

        void SelectMyClass()
        {
            string[] PlayerClass = { "Warrior", "Archer", "Mage" };

            Console.Clear();

            int selectedIndex = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                       ╔████████████████████╗    ╔████████████████████╗    ╔████████████████████╗        ");
            Console.WriteLine("                       ║██                ██║    ║██                ██║    ║██                ██║        ");
            Console.WriteLine("                       ║██       ██       ██║    ║██         ██     ██║    ║██      ████      ██║        ");
            Console.WriteLine("                       ║██       ██       ██║    ║██       ██       ██║    ║██     ██████     ██║        ");
            Console.WriteLine("                       ║██       ██       ██║    ║██      ██        ██║    ║██      ████      ██║        ");
            Console.WriteLine("                       ║██       ██       ██║    ║██    ████        ██║    ║██       ██       ██║        ");
            Console.WriteLine("                       ║██       ██       ██║    ║██      ██        ██║    ║██       ██       ██║        ");
            Console.WriteLine("                       ║██      ████      ██║    ║██    ████        ██║    ║██       ██       ██║        ");
            Console.WriteLine("                       ║██    ████████    ██║    ║██      ██        ██║    ║██       ██       ██║        ");
            Console.WriteLine("                       ║██       ██       ██║    ║██       ██       ██║    ║██       ██       ██║        ");
            Console.WriteLine("                       ║██       ██       ██║    ║██         ██     ██║    ║██       ██       ██║        ");
            Console.WriteLine("                       ║██                ██║    ║██                ██║    ║██                ██║        ");
            Console.WriteLine("                       ║████████████████████║    ║████████████████████║    ║████████████████████║        ");
            Console.WriteLine("                       ╚════════════════════╝    ╚════════════════════╝    ╚════════════════════╝        ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                   Select Your Class");

            int[] textStartX = { 30, 57, 84 };  // 각각 텍스트 X값 시작 위치 계산
            int textStartY = (Console.WindowHeight - 3); // Y값 위치 계산

            for (int i = 0; i < PlayerClass.Length; i++)  // 메뉴 출력
            {
                Console.SetCursorPosition(textStartX[i], textStartY);
                Console.WriteLine(PlayerClass[i]);
            }

            bool continueSelecting = true;

            while (continueSelecting)
            {
                // 키보드 입력 처리
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        selectedIndex = (selectedIndex - 1 + PlayerClass.Length) % PlayerClass.Length;  // 이전 메뉴 선택
                        PS.PlaySelectionSound(80);  // 띠~ 소리 출력
                        break;
                    case ConsoleKey.RightArrow:
                        selectedIndex = (selectedIndex + 1) % PlayerClass.Length;  // 다음 메뉴 선택
                        PS.PlaySelectionSound(80);
                        break;
                    case ConsoleKey.Enter:
                        if (selectedIndex == 0) // "Archer" 또는 "Mage" 선택 시 미구현 메시지 출력
                        {
                            PS.PlayEnterSound(100);
                            Console.WriteLine($"{PlayerClass[selectedIndex]}를 선택하셨습니다.");
                            player.Class = "Warrior";
                            continueSelecting = false; // 루프 종료
                            NpcTalk();
                            return;
                        }
                        else if (selectedIndex == 1)
                        {
                            PS.PlayEnterSound(100);
                            Console.WriteLine($"{PlayerClass[selectedIndex]}를 선택하셨습니다.");
                            player.Class = "Archer";
                            Console.ReadKey();  // 잠시 멈추기
                            continueSelecting = false; // 루프 종료
                            NpcTalk();
                            return;
                        }
                        else
                        {
                            PS.PlayEnterSound(100);
                            Console.WriteLine($"{PlayerClass[selectedIndex]}를 선택하셨습니다.");
                            player.Class = "Mage";
                            Console.ReadKey();  // 잠시 멈추기
                            continueSelecting = false; // 루프 종료
                            NpcTalk();
                            return;
                        }
                        break;
                }

                for (int i = 0; i < PlayerClass.Length; i++)
                {
                    Console.SetCursorPosition(textStartX[i], textStartY);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;  // 선택된 메뉴는 노란색으로 표시
                    }
                    Console.WriteLine(PlayerClass[i]);
                    Console.ResetColor();
                }
            }
        }

        void NpcTalk()
        {
            string[] NpcTalkTxt =
            {
                "\"어서 오게 어리고 작은 르탄이여. 자넨 시공의 폭풍의 선택을 받았다네.\"",
                "\"아! 내 소개를 잊었군. 나는 RATN2. 자네의 선배쯤 되는 사람이라고 할 수 있네.\"",
                "\"다름이 아닌 지금 이 세계는 마왕의 위협에 노출된 상황이지.\"",
                "\"내가 직접 가서 해치우고 싶지만, 하필이면 무릎에 화살을 맞아버렸다네.\"",
                "\"그래서 말일세. 자네가 나를 대신해서 마왕을 무찔러 줬으면 좋겠군.\"",
                "\"정말 고맙네!\"",
                "\"아, 그래! 바깥은 혼자 돌아다니기 위험하니 이걸 가져가게나!\"",
                "\"그럼 아무쪼록 부탁하네!\"",
                "당신은 [르탄이2가 쓰던 낡은 창]을 받았다!"
            };

            int NpcTxtStartX = (36);   // X값 시작 위치 계산
            int NpcTxtStartY = (23);   // Y값 시작 위치 계산

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("╔████████████████████████████████████████████████████████████████████████████████████████████████████████████████████╗");
            Console.WriteLine("║██                                                                                                                ██║");
            Console.WriteLine("║██                                      ██              ████                                                      ██║");
            Console.WriteLine("║██                                     █  █             ████                                                      ██║");
            Console.WriteLine("║██                                    █    █             ██                                                       ██║");
            Console.WriteLine("║██                                   █      █      ██████████████                                                 ██║");
            Console.WriteLine("║██                                    █    █      ████████████████                                                ██║");
            Console.WriteLine("║██                                     ████      ██████████████████                                               ██║");
            Console.WriteLine("║██                                     ████     ████████████████████                                              ██║");
            Console.WriteLine("║██                                     ████     ██   ██████████   ██                                              ██║");
            Console.WriteLine("║██                                     ████     ██     ██████     ██                                              ██║");
            Console.WriteLine("║██                                     ████     ██   ██  ██  ██   ██                                              ██║");
            Console.WriteLine("║██                                     ████     ████            ████                                              ██║");
            Console.WriteLine("║██                                    ██████      ████        ████  ██████████                                    ██║");
            Console.WriteLine("║██                                  ██      ██████  ██        ██  ██          ██                                  ██║");
            Console.WriteLine("║██                                  ██             █  ████████  ███            ██                                 ██║");
            Console.WriteLine("║██                                   █████████████   █        █  █              █                                 ██║");
            Console.WriteLine("║██                                     ████  ██ ██    ████████   ██            ██                                 ██║");
            Console.WriteLine("║██                                     ████  ██ ██                ██          ██                                  ██║");
            Console.WriteLine("║████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("║██                              ██                                                                                ██║");
            Console.WriteLine("║██                              ██                                                                                ██║");
            Console.WriteLine("║██                              ██                                                                                ██║");
            Console.WriteLine("║██            RTAN2             ██                                                                                ██║");
            Console.WriteLine("║██                              ██                                                                                ██║");
            Console.WriteLine("║██                              ██                                                                                ██║");
            Console.WriteLine("║██                              ██                                                                                ██║");
            Console.WriteLine("║████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            for (int i = 0; i < NpcTalkTxt.Length; i++)
            {
                Console.SetCursorPosition(NpcTxtStartX, NpcTxtStartY);
                Console.WriteLine(NpcTalkTxt[i]);

                PS.PlayEnterSound(100);
                Console.ReadKey(); // 키 입력 대기
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("╔████████████████████████████████████████████████████████████████████████████████████████████████████████████████████╗");
                Console.WriteLine("║██                                                                                                                ██║");
                Console.WriteLine("║██                                      ██              ████                                                      ██║");
                Console.WriteLine("║██                                     █  █             ████                                                      ██║");
                Console.WriteLine("║██                                    █    █             ██                                                       ██║");
                Console.WriteLine("║██                                   █      █      ██████████████                                                 ██║");
                Console.WriteLine("║██                                    █    █      ████████████████                                                ██║");
                Console.WriteLine("║██                                     ████      ██████████████████                                               ██║");
                Console.WriteLine("║██                                     ████     ████████████████████                                              ██║");
                Console.WriteLine("║██                                     ████     ██   ██████████   ██                                              ██║");
                Console.WriteLine("║██                                     ████     ██     ██████     ██                                              ██║");
                Console.WriteLine("║██                                     ████     ██   ██  ██  ██   ██                                              ██║");
                Console.WriteLine("║██                                     ████     ████            ████                                              ██║");
                Console.WriteLine("║██                                    ██████      ████        ████  ██████████                                    ██║");
                Console.WriteLine("║██                                  ██      ██████  ██        ██  ██          ██                                  ██║");
                Console.WriteLine("║██                                  ██             █  ████████  ███            ██                                 ██║");
                Console.WriteLine("║██                                   █████████████   █        █  █              █                                 ██║");
                Console.WriteLine("║██                                     ████  ██ ██    ████████   ██            ██                                 ██║");
                Console.WriteLine("║██                                     ████  ██ ██                ██          ██                                  ██║");
                Console.WriteLine("║████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
                Console.WriteLine("║██                              ██                                                                                ██║");
                Console.WriteLine("║██                              ██                                                                                ██║");
                Console.WriteLine("║██                              ██                                                                                ██║");
                Console.WriteLine("║██            RTAN2             ██                                                                                ██║");
                Console.WriteLine("║██                              ██                                                                                ██║");
                Console.WriteLine("║██                              ██                                                                                ██║");
                Console.WriteLine("║██                              ██                                                                                ██║");
                Console.WriteLine("║████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                if (i == NpcTalkTxt.Length - 1) // 마지막 대사 전까지만 키 입력 대기
                {
                    return;
                }
            }


        }

        player.Inventory.Add("르탄이2가 쓰던 낡은 창");  // 창을 가져옴

        while (true)
        {

            Console.Clear();


            int startX = 95;
            int startY = 20;

            // 메뉴 출력
            Console.WriteLine("╔██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████╗");
            Console.WriteLine("║██                                 ▅████        ████████ ▅        ████                             █       █        ██║");
            Console.WriteLine("║██ ████████████                  ▅███          ▅              ▅     ██                            █     █ █         ██║");
            Console.WriteLine("║██ ███████████████▅             ▅███    ████       _______█         ███                       █    █   █   █        ██║");
            Console.WriteLine("║██       ██        █           ▅███    ██  ██    ████████████      ▅██                         █  █     █     █     ██║");
            Console.WriteLine("║██      ██                    ▅███    ███__██    ██   ███████     ▅███                   █    █              █  █   ██║");
            Console.WriteLine("║██     ████████████           ▅███ ▅            ███___████████    ███                   █   █      ▅▅▅▅▅▅     █  █  ██║");
            Console.WriteLine("║██   ████████████████          ██▅      ▅████▅      ▅          ▅████                     █ █     ▅████████▅     █   ██║");
            Console.WriteLine("║██ ███████████████████          ██▅   ▅█     ██   ▅           ████                      █   █   ▅█        ██▅       ██║");
            Console.WriteLine("║██ ████████████████████          ██▅  ██     ██▅           ▅████                          █    ▅█  ▅████    ██   █  ██║");
            Console.WriteLine("║██ █████████████████████          ▅█  ██     █████       ████                            █     ██  ██████    ██ █   ██║");
            Console.WriteLine("║██ ██████████████████████           ██   ▅ ▅     ████████                                   █                       ██║");
            Console.WriteLine("║██ █████████████████  ███                                                                  █            █      █    ██║");
            Console.WriteLine("║██ ██████████████  ██  ██                                                                              █        █   ██║");
            Console.WriteLine("║██ ██████████████      █                                                                         █             █    ██║");
            Console.WriteLine("║██ ██████████████████  █                                                                              █             ██║");
            Console.WriteLine("║██ ████████████████████                                                                                             ██║");
            Console.WriteLine("║██ ████████████████████                                                                                             ██║");
            Console.WriteLine("║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╔████████████████████╗");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██   1. 내 정보   ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██   2. 상점      ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██   3. 인벤토리  ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██   4. 던전      ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██   5. 종료      ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║████████████████████║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╚════════════════════╝");

            Console.SetCursorPosition(startX, startY++);
            Console.Write("메뉴 선택 : ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    player.ShowInfo();
                    break;
                case "2":
                    ShopMenu(player);
                    break;
                case "3":
                    InventoryMenu(player);
                    break;
                case "4":
                    DengeonMenu();
                    // 여기에 던전 결과 처리 코드 추가 가능
                    break;
                case "5":
                    Console.WriteLine("게임을 종료합니다.");
                    return;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }

            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
            Console.Clear();
        }

        static void DengeonMenu()
        {
            int startX = 95;
            int startY = 20;

            Console.Clear();

            Console.WriteLine("╔██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████╗");
            Console.WriteLine("║██                                                                                                   ██████         ██║");
            Console.WriteLine("║██         ██                  ████                   ████████████████████                         ████             ██║");
            Console.WriteLine("║██        ████               ████████               ██                   ██████                    ██               ██║");
            Console.WriteLine("║██        ██████          ███      ███            ██                          ██                  █                 ██║");
            Console.WriteLine("║██       ████████        ██         ██          ██                             ██                                 ████║");
            Console.WriteLine("║██           █████      ██           █        ██          ▅▅▅▅▅▅▅▅▅             ██        █                      █████║");
            Console.WriteLine("║██            █████   ███            █      ██           ▅██████████▅             ███      █                     █████║");
            Console.WriteLine("║██              ████████                  ██             ████████████▅              ██      ██                  ██████║");
            Console.WriteLine("║██               ██████                   ██            ▅█████████████               ██       ███               ██████║");
            Console.WriteLine("║██                ████                   ██             ██████████████▅               ██        ███            ████ ██║");
            Console.WriteLine("║██                 ██                   ██             █████████████████               ██        █████       █████  ██║");
            Console.WriteLine("║██                                      ██            ███████████████████               ██          ████████████    ██║");
            Console.WriteLine("║██                             █       ██            █████████████████████               ██           █████████     ██║");
            Console.WriteLine("║██                           ██       ██             ██████████████████████              ██            ██████       ██║");
            Console.WriteLine("║██                         ███        ██            ████████████████████████             ██                         ██║");
            Console.WriteLine("║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("║██ ㆍ 으으.. 던전은 정말 무섭다!                                                                                    ██║");
            Console.WriteLine("║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            

            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╔████████████████████╗");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██    1. 도망     ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██    2. 도망     ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██    3. 도망     ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██    4. 도망     ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║████████████████████║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╚════════════════════╝");

            Console.SetCursorPosition(startX, startY++);
            Console.Write("메뉴 선택 : ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("╔██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████╗");
            Console.WriteLine("║██                                                                                                                  ██║");
            Console.WriteLine("║██                                                      ████                                                        ██║");
            Console.WriteLine("║██                                                      ████                                                        ██║");
            Console.WriteLine("║██                                                       ██                                                         ██║");
            Console.WriteLine("║██                                                 ██████████████                                                   ██║");
            Console.WriteLine("║██                                                ████████████████                                                  ██║");
            Console.WriteLine("║██                                               ██████████████████                                                 ██║");
            Console.WriteLine("║██                                              ████████████████████                                                ██║");
            Console.WriteLine("║██                                    ████      ██   ██████████   ██      ████                                      ██║");
            Console.WriteLine("║██                                  ██   ██     ██     ██████     ██     ██   ██                                    ██║");
            Console.WriteLine("║██                                  ██    ██    ██   ██  ██  ██   ██    ██    ██                                    ██║");
            Console.WriteLine("║██                                    ██    ██  ██                ██  ██    ██                                      ██║");
            Console.WriteLine("║██                                      ██    ██  ████        ████  ██    ██                                        ██║");
            Console.WriteLine("║██                                       ██     ██  ██        ██  ██     ██                                         ██║");
            Console.WriteLine("║██                                         ██      █  ████████  █      ██                                           ██║");
            Console.WriteLine("║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("║██ ㆍ던전에서 도망쳤습니다.                                                                                         ██║");
            Console.WriteLine("║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }

        static void ShopMenu(Player player)
        {
            int startX = 95;
            int startY = 20;

            Console.Clear();

            Console.WriteLine("╔██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████╗");
            Console.WriteLine("║██                             ██                                                                                   ██║");
            Console.WriteLine("║██           ███████████       ██                                    ██                                             ██║");
            Console.WriteLine("║██         ███████████████     ██    ██████                          ██               ██████      ██████            ██║");
            Console.WriteLine("║██        ███   █     █  ██    ██    ██████                          ██              █     ██    ██     █           ██║");
            Console.WriteLine("║██              █    █         ██     ██   ██                       ████             ██     ██████     ██           ██║");
            Console.WriteLine("║██          ████████████       ██      ██   ██                      ████            █  ██     ██     ██  █          ██║");
            Console.WriteLine("║██        ███████████████      ██       ██    ██                    ████            █   ███   ██   ███   █          ██║");
            Console.WriteLine("║██       █████████████████     ██        ██      ██                 ████            █      ██ ██  ██     █          ██║");
            Console.WriteLine("║██      ███████████████████    ██       ██         ██                ██             █   ██  ██████  ██   █          ██║");
            Console.WriteLine("║██      ██ ██    ██  ██████    ██      ██            ██              ██             █   ██    ██    ██   █          ██║");
            Console.WriteLine("║██      ██        █████████    ██      ██         ██████         ██████████        █     ██        ██     █         ██║");
            Console.WriteLine("║██      ██        ████████     ██      ████████████████          ██████████         ███ ██          ██ ███          ██║");
            Console.WriteLine("║██     ████████████████████    ██         ████████████               ██                █  ████  ████  █             ██║");
            Console.WriteLine("║██    ██  ████████        ██   ██           ████████                 ██                ████████████████             ██║");
            Console.WriteLine("║██  ██  ██          ████   ██  ██                                                                                   ██║");
            Console.WriteLine("║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("║██ ㆍ \"원하는 것을 골라보게.\"              10 GOLD                50 GOLD                   30 GOLD                 ██║");
            Console.WriteLine("║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╔████████████████████╗");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██  1. 물약       ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██  2. 검         ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██  3. 갑옷       ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██  4. 종료       ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║████████████████████║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╚════════════════════╝");

            Console.SetCursorPosition(startX, startY++);
            Console.Write("상품 선택 : ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (player.Gold >= 10)
                    {
                        player.Gold -= 10;
                        player.Inventory.Add("물약");
                        Console.WriteLine("물약을 구매했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;
                case "2":
                    if (player.Gold >= 50)
                    {
                        player.Gold -= 50;
                        player.Inventory.Add("검");
                        Console.WriteLine("검을 구매했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;
                case "3":
                    if (player.Gold >= 30)
                    {
                        player.Gold -= 30;
                        player.Inventory.Add("갑옷");
                        Console.WriteLine("갑옷을 구매했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }
        }

        static void InventoryMenu(Player player)
        {
            int startX = 87;
            int startY = 18;
            int anotherX = 90;
            int anotherY = 19;

            // 메뉴 출력
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╔███████████████████████████████╗");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                           ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                           ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                           ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                           ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                           ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                           ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║██                           ██║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("║███████████████████████████████║");
            Console.SetCursorPosition(startX, startY++);
            Console.WriteLine("╚═══════════════════════════════╝");

            foreach (var item in player.Inventory)
            {
                Console.SetCursorPosition(anotherX, anotherY++);
                Console.WriteLine($"ㆍ {item}");
            }
        }

    }
}