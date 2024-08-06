
namespace CodingTest2 {
    /// <summary>
    /// 날짜   : 2024.08.06
    /// 사이트 : 프로그래머스
    /// 문제   : 최댓값과 최솟값
    /// 링크   : https://school.programmers.co.kr/learn/courses/30/lessons/43162
    /// </summary>
    public class Solution {
        public string solution(string s) {

            string answer = "";

            string[] strArr = s.Split(" ");
            int[] intArr = new int[strArr.Length];

            //정수변환
            for (int i = 0; i < strArr.Length; i++) {
                intArr[i] = int.Parse(strArr[i]);
            }

            //정렬
            Array.Sort(intArr);

            //문자열 반환.
            answer += intArr[0];
            answer += " ";
            answer += intArr[intArr.Length - 1];

            return answer;
        }
    }

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
        }
    }
}
