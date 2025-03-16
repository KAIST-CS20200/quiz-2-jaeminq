module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec inner_col (n: uint64) i=
    if n=1UL then i
    else 
      if n%2UL=0UL then inner_col (n/2UL) (i+1)
      else inner_col (3UL*n+1UL) (i+1)
  inner_col (uint64 n) 0

