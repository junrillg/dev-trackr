# DevTrackr Starter Repo + 12-Week Task Plan

This repo is your starting point for **DevTrackr**, a lightweight task and project management app built in C#/.NET. It doubles as a **12-week guided study plan**, where each week you implement project features that directly reinforce C#/.NET concepts from *C# in Depth (4th ed.)*.

---

## Project Structure

```plaintext
DevTrackr/
├── DevTrackr.Core/        # Domain layer (entities, interfaces, services)
│   ├── Entities/
│   │   ├── TaskItem.cs
│   │   ├── Project.cs
│   │   └── User.cs
│   ├── Interfaces/
│   │   └── IRepository.cs
│   └── Services/
│       └── TaskService.cs
│
├── DevTrackr.Api/         # Web API (ASP.NET Core)
│   ├── Program.cs
│   └── Properties/
│       └── launchSettings.json
│
├── DevTrackr.Tests/       # Unit tests (xUnit)
│   └── TaskServiceTests.cs
│
├── ProgressTracker/       # Progress tracking utility
│   ├── Program.cs
│   └── ProgressTracker.csproj
│
├── progress.bat           # Script to run progress tracker
├── CHECKLIST.md           # Detailed weekly checklist
├── DAILY_PLAN_TEMPLATE.md # Template for daily tracking
├── PROJECT_ALIGNMENT.md   # Project structure and plan alignment
│
└── README.md
```

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 / VS Code / Rider

### Build & Run

```bash
# Restore dependencies
dotnet restore

# Build all projects
dotnet build

# Run the Web API
dotnet run --project DevTrackr.Api
```

The API will run on `https://localhost:5001` or `http://localhost:5000` by default.

---

## Tracking Tools

This repository includes several tools to help you track your progress through the 12-week plan:

- `CHECKLIST.md` - Detailed breakdown of weekly tasks
- `DAILY_PLAN_TEMPLATE.md` - Template for daily progress tracking
- `PROJECT_ALIGNMENT.md` - Shows how current implementation aligns with the plan
- `ProgressTracker/` - Simple command-line tool to track completed days
- `progress.bat` - Windows batch script to build and run the progress tracker

To use the progress tracker:
```bash
# Mark a day as complete
progress complete 1 3

# Show current progress
progress status

# Reset all progress
progress reset
```

---

## Core Concepts (Initial Code)

- `TaskItem` entity (class, properties, enums)
- `IRepository<T>` generic interface
- `TaskService` business logic with validation
- Unit tests with **xUnit + Moq**

These serve as Week 1 foundations.

---

# 12-Week Study + Build Plan

Each week ties DevTrackr tasks to specific C#/.NET concepts explained in *C# in Depth (4th ed.)*. Read the book section first, then implement the code tasks.

---

## Week 1 — Fundamentals & type system

- **Read:** Ch. 1 (type system & philosophy).
- **Code:** Entities (`User`, `Project`, `TaskItem`, enums). Console CRUD with `List<TaskItem>`.
- **Exercise:** Show value vs reference type behavior.
- **Checkpoint:** Console CRUD works; explain class vs struct.

## Week 2 — Generics, delegates & events

- **Read:** Ch. 2 (Generics, delegates, events).
- **Code:** Implement `InMemoryRepository<T>`; add events (`TaskAssigned`).
- **Exercise:** Subscribe with lambda & method-group.
- **Checkpoint:** Repository + events tested.

## Week 3 — LINQ, lambdas & anonymous types

- **Read:** Ch. 3 (LINQ, lambda expressions).
- **Code:** Replace loops with LINQ filters (status, due dates, search). Add DTO projections.
- **Exercise:** Compare query vs method syntax.
- **Checkpoint:** Explain deferred vs immediate execution.

## Week 4 — Async/await basics

- **Read:** Ch. 5 (async usage, cancellation).
- **Code:** Add async repository methods; implement `FileTaskRepository` (JSON I/O with cancellation).
- **Exercise:** Run two tasks concurrently & combine results.
- **Checkpoint:** Async CRUD + cancellation works.

## Week 5 — EF Core integration

- **Read:** LINQ notes + EF docs.
- **Code:** Add `DevTrackrDbContext`, migrations, seed demo data. Replace repo with EF Core.
- **Exercise:** Fix N+1 query by projecting.
- **Checkpoint:** API persists to SQLite.

## Week 6 — C# 6 modern syntax

- **Read:** Ch. 8–10 (expression-bodied, interpolated strings, `nameof`, null-conditional, caller info).
- **Code:** Refactor services/models with modern syntax.
- **Exercise:** Caller info for logging.
- **Checkpoint:** Cleaner idiomatic C# code.

## Week 7 — Tuples, deconstruction, pattern matching

- **Read:** Ch. 11–12.
- **Code:** Add `TaskStatisticsService` with tuple returns; use deconstruction & pattern matching in rules.
- **Exercise:** Implement `MinMax()` example from book.
- **Checkpoint:** Tuple + pattern usage works.

## Week 8 — Ref, Span<T>, performance

- **Read:** Ch. 13 + Span restrictions.
- **Code:** Optimize a string operation with `Span<char>` + BenchmarkDotNet.
- **Exercise:** Recreate book’s Span allocation example.
- **Checkpoint:** Benchmark proves allocation reduction.

## Week 9 — Advanced async internals

- **Read:** Ch. 6 (state machine, try/finally, context).
- **Code:** Add `OverdueCheckerService` (BackgroundService) with cancellation & try/finally.
- **Exercise:** Test cancellation mid-await.
- **Checkpoint:** Service behaves safely under shutdown.

## Week 10 — Resilience & channels

- **Read:** Async best practices + external Polly docs.
- **Code:** Add `System.Threading.Channels` queue for notifications; wrap calls with Polly retry/circuit-breaker.
- **Exercise:** Inject failures & observe breaker logs.
- **Checkpoint:** Notifications resilient to transient failures.

## Week 11 — Testing & nullable refs

- **Read:** Ch. 15 (nullable refs + migration).
- **Code:** Expand unit/integration tests; enable nullable refs incrementally.
- **Exercise:** Introduce null bug & see compiler warning.
- **Checkpoint:** Tests + NRT warnings addressed.

## Week 12 — Capstone wrap-up

- **Read:** Ch. 1 + 15 (design philosophy).
- **Code:** Finalize repo with docs (README, CAPSTONE.md).
- **Deliver:** Short demo showing features tied to language concepts.
- **Checkpoint:** Tag v1.0 and summarize learnings.

---

## ✅ How to Work Each Week

1. **Read** book sections first.
2. **Code** the DevTrackr feature.
3. **Run exercises** (from book examples).
4. **Write a summary** in README or CAPSTONE.md.

This way, by Week 12 you’ll have a working project *and* mastery of modern C#/.NET.

---

## License

MIT