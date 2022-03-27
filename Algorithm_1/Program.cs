using System;

namespace Algorithm_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';
            int lastTick = 0;
            while(true) // 게임 실행 방식
            {
                #region 프레임 관리 (region 접었다 폈다하기)
                // FPS 프레임 (60 프레임 OK /30 프레임 이하로 NO)
                int currentTick = System.Environment.TickCount; // ms
    
                // 만약에 경과한 시간이 1/30초보다 작다면
                if (currentTick - lastTick < WAIT_TICK) // 1초는 1000ms 경과시간
                    continue;
                lastTick = currentTick;
                #endregion

                // 입력

                // 로직

                // 렌더링
                Console.SetCursorPosition(0, 0);
                
                for ( int i =0; i < 25; i++)
                {
                    for (int j = 0; j<25; j++)
                    {
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}