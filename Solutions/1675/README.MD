# 1675 : 稀疏矩阵乘积

Time Limit:10000ms
Case Time Limit:1000ms
Memory Limit:256MB

## Description

给定两个N × N的稀疏矩阵A和B，其中矩阵A有P个元素非0，矩阵B有Q个元素非0。请计算两个矩阵的乘积C = A × B并且输出C中所有非0的元素。

## Input

第一行包含三个整数N, P, Q    

以下P行每行三个整数i, j, k表示A矩阵的一个非0元素：Aij = k  

以下Q行每行三个整数i, j, k表示B矩阵的一个非0元素：Bij = k  

对于80%的数据，1 ≤ N, P, Q ≤ 200  

对于100%的数据, 1 ≤ N, P, Q ≤ 2000, 1 ≤ i, j ≤ N, 0 ≤ k ≤ 100

## Output

输出若干行，按先行后列的顺序输出矩阵C的每一个非0元素  

每行三个整数i, j, k表示C矩阵的一个非0元素：Cij = k

### Sample Input

```shell
2 2 4  
1 1 1  
2 2 1  
1 1 1  
1 2 2  
2 1 3  
2 2 4
```

### Sample Output

```shell
1 1 1  
1 2 2  
2 1 3  
2 2 4
```
