# 1288: Font Size

Time Limit:10000ms

Case Time Limit:1000ms

Memory Limit:256MB

## Description

Steven loves reading book on his phone. The book he reads now consists of N paragraphs and the i-th paragraph contains ai characters.

Steven wants to make the characters easier to read, so he decides to increase the font size of characters. But the size of Steven's phone screen is limited. Its width is W and height is H. As a result, if the font size of characters is S then it can only show ⌊W / S⌋ characters in a line and ⌊H / S⌋ lines in a page. (⌊x⌋ is the largest integer no more than x)  

So here's the question, if Steven wants to control the number of pages no more than P, what's the maximum font size he can set? Note that paragraphs must start in a new line and there is no empty line between paragraphs.

## Input
Input may contain multiple test cases.

The first line is an integer TASKS, representing the number of test cases.

For each test case, the first line contains four integers N, P, W and H, as described above.

The second line contains N integers a1, a2, ... aN, indicating the number of characters in each paragraph.



For all test cases,

1 <= N <= 103,

1 <= W, H, ai <= 103,

1 <= P <= 106,

There is always a way to control the number of pages no more than P.

## Output
For each testcase, output a line with an integer Ans, indicating the maximum font size Steven can set.

### Sample Input
```
2
1 10 4 3
10
2 10 4 3
10 10
```
### Sample Output
```
3
2
```