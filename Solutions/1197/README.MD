# 1197 : Give My Text Back

Time Limit:10000ms

Case Time Limit:1000ms

Memory Limit:256MB

## Description

To prepare for the English exam Little Ho collected many digital reading materials. Unfortunately the materials are messed up by a malware.

It is known that the original text contains only English letters (a-zA-Z), spaces, commas, periods and newlines, conforming to the following format:

1. Each sentence contains at least one word, begins with a letter and ends with a period.

2. In a sentence the only capitalized letter is the first letter.

3. In a sentence the words are separated by a single space or a comma and a space.

4. The sentences are separated by a single space or a single newline.

It is also known the malware changes the text in the following ways:

1. Changing the cases of letters.

2. Adding spaces between words and punctuations.

Given the messed text, can you help Little Ho restore the original text?

## Input
A string containing no more than 8192 English letters (a-zA-Z), spaces, commas, periods and newlines which is the messed text.

## Output
The original text.

### Sample Input
```
my Name  is Little   Hi.
His   name IS Little ho  ,  We are   friends.
```
### Sample Output
```
My name is little hi.
His name is little ho, we are friends.
```