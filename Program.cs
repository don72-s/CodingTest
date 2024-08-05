namespace CodingTest {

    /// <summary>
    /// 날짜   : 2024.08.05
    /// 사이트 : 프로그래머스
    /// 문제   : 네트워크
    /// 링크   : https://school.programmers.co.kr/learn/courses/30/lessons/43162
    /// </summary>
    public class Solution {
        public int solution(int n, int[,] computers) {

            int answer = 0;

            //방문했는지 [이미 체크된 네트워크의 컴퓨터인지] 확인하는 배열
            bool[] isVisit = new bool[n];

            //다음 방문할 컴퓨터를 나타내는 큐
            List<int> queue = new List<int>();

            //모든 컴퓨터에 대해 반복
            for (int i = 0; i < n; i++) {

                //체크하지 않은 컴퓨터인경우
                if (!isVisit[i]) {

                    //체크 확인 설정.
                    isVisit[i] = true;

                    //네트워크 갯수 하나 추가
                    answer++;

                    //이 컴퓨터부터 너비우선탐색 시작
                    queue.Add(i);

                    //더이상 탐색할 노드가 없을때까지 반복
                    while (queue.Count > 0) {

                        //노드를 꺼내오고 제거
                        int val = queue[0];
                        queue.RemoveAt(0);

                        //조사대상 노드와 연결된 모든 노드 체크
                        for (int j = 0; j < n; j++) {

                            //대상 노드와 연결되어있고, 네트워크 체크가 되어있지 않는 컴퓨터라면
                            if (!isVisit[j] && computers[val, j] == 1) {

                                //현재 네트워크에 포함시키고
                                isVisit[j] = true;
                                //다음 조사대상 큐에 삽입.
                                queue.Add(j);

                            }

                        }

                    }

                }

            }


            return answer;
        }
    }


    internal class Program {

        static void Main(string[] args) {

            Solution solution = new Solution();

        }
    }
}
