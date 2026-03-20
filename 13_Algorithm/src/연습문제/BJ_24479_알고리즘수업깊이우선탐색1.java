package 연습문제;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.StringTokenizer;

public class BJ_24479_알고리즘수업깊이우선탐색1 {
    static int cnt;
    static int[] check;
    static ArrayList<ArrayList<Integer>> graph = new ArrayList<>();
    static StringBuilder sb = new StringBuilder();

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        StringTokenizer st = new StringTokenizer(br.readLine());

        int N = Integer.parseInt(st.nextToken()); // 정점의 개수
        int M = Integer.parseInt(st.nextToken()); // 간선의 개수
        int R = Integer.parseInt(st.nextToken()); // 시작 정점

        check = new int[N + 1];

        // 정점만큼의 배열을 만들어준다.
        for(int i = 0; i <= N; i++){
            graph.add(new ArrayList<>());
        }

        // 그래프를 완성해준다.
        for(int i = 0; i < M; i++){
            st = new StringTokenizer(br.readLine());

            int u = Integer.parseInt(st.nextToken()); // 정점 u
            int v = Integer.parseInt(st.nextToken()); // 정점 v

            graph.get(u).add(v);
            graph.get(v).add(u);
        }

        // 그래프 오름차순 정렬
        for (ArrayList<Integer> i : graph) {
            Collections.sort(i);
        }

        // 시작 노드 부터, 각 노드가 몇번째로 탐색되었는지 확인하는 변수 cnt 초기화
        cnt = 1;

        dfs(R);

        for(int i = 1; i < check.length; i++){
            sb.append(check[i]).append("\n");
        }

        System.out.println(sb);
    }

    public static void dfs(int v){
        // 현재 노드가 몇번째로 탐색되었는지 순차적으로 check 배열에 저장한다.
        check[v] = cnt;

        // 정점 v인 연결 리스트의 인접 리스트(인접 노드) 탐색
        for(int i = 0; i < graph.get(v).size(); i++){
            int n = graph.get(v).get(i); // 정점 v의 인접 노드 n

            // n의 방문 여부를 체크하여, 방문 사실이 없으면 cnt++을 해주고 탐색 계속
            if(check[n] == 0){
                cnt++;
                dfs(n);
            }
        }
    }
}
