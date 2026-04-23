# Algorithms and Data Structures

C# repository for practicing and implementing data structures and algorithms from scratch.

## Tech Stack

- .NET SDK `10.0` (`net10.0`)
- C#
- xUnit

## Repository Structure

```text
AlgorithmsAndDataStructures.sln
src/
  Algorithms/
  DataStructures/
tests/
  Algorithms.Tests/
  DataStructures.Tests/
```

`src/` contains implementations, and `tests/` contains unit tests for each area.

## Getting Started

```bash
dotnet restore AlgorithmsAndDataStructures.sln
dotnet build AlgorithmsAndDataStructures.sln
dotnet test AlgorithmsAndDataStructures.sln
```

## Development Guidelines

- Keep implementations simple and focused on correctness first.
- Add unit tests for normal paths, edge cases, and failure scenarios.
- Prefer generic implementations (`<T>`) when possible.

## Project Goals

- Implement data structures from scratch.
- Implement classic algorithms with clear complexity tradeoffs.

## Roadmap

- Linear structures (lists, stacks, queues)
- Trees and graphs
- Searching and sorting algorithms
- Traversal and pathfinding algorithms
- Complexity and performance benchmarks
