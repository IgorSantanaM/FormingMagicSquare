# Forming a Magic Square

## Problem Description

We define a magic square to be a 3x3 matrix of distinct positive integers from 1 to 9 where the sum of any row, column, or diagonal of length 3 is always equal to the same number: the magic constant.

Given a 3x3 matrix `s` of integers in the inclusive range [1, 9], we can convert any digit `a` to any other digit `b` in the range [1, 9] at a cost of |a - b|. The goal is to convert the input matrix into a magic square at minimal cost. Print this cost.

### Example

**Input:**
` s = [[5, 3, 4],
      [1, 5, 8],
      [6, 4, 2]]`

**Output:**
`7`
**Explanation:**
The matrix looks like this:
`5 3 4
1 5 8
6 4 2`
We can convert it to the following magic square:
`8 3 4
1 5 9
6 7 2`
This transformation took three replacements at a cost of 7.

## Function Description

Complete the `formingMagicSquare` function in the provided code template.

### Parameters

- **int s[3][3]**: a 3x3 array of integers

### Returns

- **int**: the minimal total cost of converting the input square to a magic square

### Input Format

Each of the 3 lines contains three space-separated integers of row `s[i]`.

## Constraints

- The matrix `s` contains integers in the inclusive range [1, 9].

### Sample Input 0
`4 9 2
3 5 7
8 1 5`

### Sample Output 0
`1`

## Solution Approach

To solve this problem, we can break down the approach into the following steps:

1. **Generate All Magic Squares**: Precompute all possible 3x3 magic squares. There are 8 unique configurations due to permutations and reflections.

2. **Calculate Conversion Costs**: For each generated magic square configuration, compute the cost to transform the input matrix `s` into that magic square. The cost is defined as the sum of absolute differences between corresponding elements of `s` and the target magic square.

3. **Find Minimum Cost**: Iterate through all computed costs and find the minimum cost.

By precomputing the possible magic squares and comparing the input matrix against these, we can efficiently determine the minimal transformation cost.

## Repository Structure

- **README.md**: This file, describing the problem and solution approach.
- **Solution.cs**: The C# implementation of the solution (not included in this README).

Feel free to contribute or provide feedback!


