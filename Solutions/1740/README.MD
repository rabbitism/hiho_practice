# 1740 : 替换函数

Time Limit:10000ms
Case Time Limit:1000ms
Memory Limit:256MB

## Description

已知替换函数replace(c1, c2)的作用是把一个字符串中所有的c1字符替换成c2字符。  

请你判断能否使用replace函数将字符串S变成D。  

你可以调用replace函数任意多次。

## Input

输入包含多组数据。  

第一行包含一个整数T，代表数据组数。  

每组数据包含两行，分别是字符串S和D。

1 ≤ T ≤ 10

S和T都只包含小写字母，且1 ≤ |S| = |D| ≤ 1000

## Output

对于每组数据输出YES或者NO，表示能否使用replace函数将字符串S变成D。

### Sample Input

```shell
2  
aaabb  
ccccc  
aaabbbbb  
cccccddd
```

### Sample Output

```shell
YES  
NO
```
