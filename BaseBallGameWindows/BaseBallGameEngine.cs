using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBallGameWindows
{
    class BaseBallGameEngine
    {
        int[] quiz = new int[3];
        int strike = 0;
        int ball = 0;

        internal void Init()
        {
            //quiz내기
            //임의의 숫자를 중복없이
            //quiz배열에 넣기
            int[] su = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i, j, temp;
            Random r = new Random();
            for (int n = 0; n < 100; n++)
            {
                i = r.Next(0, su.Length);
                j = r.Next(0, su.Length);
                temp = su[i];
                su[i] = su[j];
                su[j] = temp;
            }

            for (int k = 0; k < quiz.Length; k++)
            {
                quiz[k] = su[k];
            }

            return;
        }

        internal void Play(string input)
        {
            //quiz랑 input이랑 비교해서 strike, ball 판정하기
            //input을 int[]로 바꾸자
            //quiz를 for문으로 돌고
            //input을 for문으로 돌고
            //하나씩 꺼내어 숫자가 같으면
            //자릿수가 같으면 strike++
            //자릿수가 다르면 ball++
            strike = 0;
            ball = 0;
            //Console.WriteLine("quiz : {0}{1}{2}{3}", quiz[0], quiz[1], quiz[2],quiz[3]);
            int[] inputArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = input[i] - '0';
            }
            for (int i = 0; i < quiz.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (quiz[i] == inputArray[j])
                    {
                        if (i == j)
                        {
                            strike++;
                        }
                        else
                        {
                            ball++;
                        }
                    }
                }
            }

            return;
        }

        internal int GetQuizLength()
        {
            return quiz.Length;
        }

        internal int GetStrike()
        {
            return strike;
        }

        internal int GetBall()
        {
            return ball;
        }
        internal string GetQuiz()
        {
            return String.Format("{0} {1} {2}", quiz[0], quiz[1], quiz[2]);
        }
    }
}
