# apbd-cw1-git-s29216

A small .NET console application for calculating statistics on a set of numbers.
Created as part of APBD Tutorial 1 (Git and GitHub).

## How to run

```
cd StatisticsApp
dotnet run
```

Then enter integers separated by spaces, e.g. `4 8 15 16 23 42`.

## Features

- Sum of the entered numbers
- Average of the entered numbers
- Maximum of the entered numbers

## Notes on the `feature-max` merge

Merging `feature-max` into `main` was **not** a fast-forward merge.
While `feature-max` was being developed, an independent commit
(`Document available features in README`) was added directly on `main`.
As a result both branches had commits the other did not, so the histories
diverged. Git could not simply move the `main` pointer forward and instead
created a dedicated merge commit that joins the two lines of history.
