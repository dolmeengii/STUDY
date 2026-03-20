package 연습문제;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.StringTokenizer;

public class BJ_24480_알고리즘수업깊이우선탐색2 {
    static StringTokenizer st;
    static ArrayList<ArrayList<Integer>> graph = new ArrayList<>();
    static int[] check;
    static int cnt;

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        st = new StringTokenizer(br.readLine());
        StringBuilder sb = new StringBuilder();

        int N = Integer.parseInt(st.nextToken()); // 정점의 수
        int M = Integer.parseInt(st.nextToken()); // 간선의 수
        int R = Integer.parseInt(st.nextToken()); // 시작 정점

        check = new int[N+1];

        for(int i = 0; i < N; i++){
            graph.add(new ArrayList<>());
        }

        for(int i = 0; i < M; i++){
            st = new StringTokenizer(br.readLine());

            int u = Integer.parseInt(st.nextToken());
            int v = Integer.parseInt(st.nextToken());

            graph.get(u).add(v);
            graph.get(v).add(u);
        }

        for (ArrayList<Integer> i : graph) {
            Collections.sort(i);
        }

        cnt = 1;
        dfs(R);

        for(int i = 1; i < check.length; i++){
            sb.append(check[i]).append("\n");
        }

        System.out.println(sb);
    }

    public static void dfs(int R){
        check[R] = cnt;

        for(int i = 0; i < graph.get(R).size(); i++){
            int n = graph.get(R).get(i);

            if(check[n] == 0){
                cnt++;
                dfs(n);
            }
        }
    }
}
