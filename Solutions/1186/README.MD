# 1186 : Coordinates

Time Limit:10000ms

Case Time Limit:1000ms

Memory Limit:256MB

## Description

Give you two integers P and Q. Let all divisors of P be X-coordinates. Let all divisors of Q be Y-coordinates.

For example, when P=6 and Q=2, we can get the coordinates (1,1) (1,2) (2,1) (2,2) (3,1) (3,2) (6,1) (6,2).

You should print all possible coordinates in the order which is first sorted by X-coordinate when coincides, sorted by Y-coordinate.

## Input

One line with two integers P and Q(1 <= P, Q <= 10000).

## Output

The output may contains several lines , each line with two integers Xi and Yi, denoting the coordinates.

### Sample Input

```
6 2
```

### Sample Output

```
1 1
1 2
2 1
2 2
3 1
3 2
6 1
6 2
```