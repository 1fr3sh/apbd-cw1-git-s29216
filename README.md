# apbd-cw1-git-s29216

A small .NET console application for calculating statistics on a set of numbers.
Created as part of APBD Tutorial 1 (Git and GitHub).

## How to run

```
cd StatisticsApp
dotnet run
```

Then enter integers separated by spaces, e.g. `4 8 15 16 23 42`.

To build the project without running it:

```
dotnet build
```

## Features

- Sum of the entered numbers
- Average of the entered numbers
- Maximum of the entered numbers
- Minimum of the entered numbers

## Notes on the `feature-max` merge

Merging `feature-max` into `main` was **not** a fast-forward merge.
While `feature-max` was being developed, an independent commit
(`Document available features in README`) was added directly on `main`.
As a result both branches had commits the other did not, so the histories
diverged. Git could not simply move the `main` pointer forward and instead
created a dedicated merge commit that joins the two lines of history.

## Merge vs rebase (the `feature-min` branch)

The `feature-min` branch was integrated using **rebase** instead of a plain merge.
Before integrating, an independent commit (`Add build instructions to README`) was
added on `main`, so the branch was based on an older state of `main`.

- A **merge** in this situation (like `feature-max`) would have produced a merge
  commit and a visible fork/join in the history graph.
- A **rebase** instead replayed the branch commits on top of the latest `main`,
  giving each of them a new hash. The following merge into `main` was then a
  fast-forward, so the final history is a single straight line with no merge commit.

In short: merge preserves the exact branching history, while rebase rewrites the
branch to produce a cleaner, linear history.

## Submission answers

### 1. When does Git perform a fast-forward and when is a merge commit created?

Git performs a **fast-forward** when the target branch (e.g. `main`) has not received
any new commits since the feature branch was created. In that case the branches have
not diverged, so Git simply moves the branch pointer forward to the tip of the feature
branch and no extra commit is needed.

A **merge commit** is created when both branches have commits the other does not have
(the history has diverged). Git then cannot move the pointer in a straight line, so it
creates a new commit with two parents that joins the two lines of history. A merge
commit can also be forced even in a fast-forward situation with `git merge --no-ff`.

### 2. What is the practical difference between merge and rebase?

- **Merge** keeps the real history: the branch and its separate commits are preserved,
  and the integration point is a merge commit. The graph shows the actual fork and join.
- **Rebase** rewrites the branch by replaying its commits on top of the latest base
  branch, giving them new hashes. The result is a clean, linear history without merge
  commits, but the original branching shape is lost.

Practically: merge is safer and honest about how work happened (preferred for shared
branches), while rebase produces a tidier, easier-to-read history (useful for cleaning
up a local branch before integrating). Rebase should not be used on commits that have
already been pushed and shared with others.

### 3. How was the conflict resolved in your repository?

On the `feature-conflict` branch the statistics header line was changed to
`Console.WriteLine("===== Statistics Report =====");`, while on `main` the same line
was changed to `Console.WriteLine("--- Calculation Results ---");`. Merging the branch
produced a conflict on that single line.

The conflict was resolved deliberately: the conflict markers were removed and the more
descriptive branch version (`===== Statistics Report =====`) was kept as the final
header. The project was then built and run to confirm the code still works before the
merge commit was created.
