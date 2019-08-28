# 1892 : 修改字符串

Time Limit:10000ms
Case Time Limit:1000ms
Memory Limit:256MB

## Description

给定两个字符串S和T，每次小Ho可以对S进行以下操作：

选定S中的一个字符Si，将Si移动到字符串首位。  

例如对于S="ABCD"，小Ho可以选择移动B从而得到新的S="BACD"；也可以选择移动C得到"CABD"；也可以选择移动D得到"DABC"。  

请你计算最少需要几次移动操作，可以使S变成T。

## Input

第一行包含一个字符串S。  

第二行包含一个字符串T。  

对于30%的数据，1 ≤ |S| = |T| ≤ 10  

对于100%的数据，1 ≤ |S| = |T| ≤ 100000  S和T都只包含大写字母

## Output

一个整数代表答案。如果无法达成，输出-1。

### Sample Input

```shell
ABCD  
DBAC
```

### Sample Output

```shell
2
```
