# 1335 : Email Merge

Time Limit:10000ms
Case Time Limit:1000ms
Memory Limit:256MB

## Description

You are given a list of usernames and their email addresses in the following format:

alice 2 alice@hihocoder.com alice@gmail.com
bob 1 bob@qq.com
alicebest 2 alice@gmail.com alice@qq.com
alice2016 1 alice@qq.com

Your task is to merge the usernames if they share common email address:

alice alicebest alice2016
bob

## Input

The first line contains an integer N, denoting the number of usernames. (1 < N ≤ 10000)

The following N lines contain N usernames and their emails in the previous mentioned format.

Each username may have 10 emails at most.

## Output

Output one merged group per line.

In each group output the usernames in the same order as the input.

Output the groups in the same order as their first usernames appear in the input.

### Sample Input

```shell
4
alice 2 alice@hihocoder.com alice@gmail.com
bob 1 bob@qq.com
alicebest 2 alice@gmail.com alice@qq.com
alice2016 1 alice@qq.com
```

### Sample Output

```shell
alice alicebest alice2016
bob
```
