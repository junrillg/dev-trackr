# DevTrackr Project Structure & 12-Week Plan Alignment

This document shows how the current project structure aligns with the 12-week study plan and what has been implemented so far.

## Current Project Structure

```
DevTrackr/
├── DevTrackr.Core/        # Domain layer (entities, interfaces, services)
│   ├── Entities/
│   │   ├── TaskItem.cs    # Implemented
│   │   ├── Project.cs     # Implemented
│   │   └── User.cs        # Implemented
│   ├── Interfaces/
│   │   └── IRepository.cs # Implemented
│   └── Services/
│       └── TaskService.cs # Partially implemented
│
├── DevTrackr.Api/         # Web API (ASP.NET Core)
│   ├── Program.cs         # Implemented with minimal API
│   └── Properties/
│       └── launchSettings.json
│
├── DevTrackr.Tests/       # Unit tests (xUnit)
│   └── TaskServiceTests.cs # Partially implemented
│
└── README.md
```

## 12-Week Plan Progress

### Week 1 — Fundamentals & Type System
**Status**: ✅ Started | 🚧 In Progress | ⬜ Not Started

**Current Implementation**:
- Entities (`TaskItem`, `User`, `Project`) are implemented with basic properties
- `TaskStatus` enum is defined
- Web API has basic CRUD operations using in-memory storage
- Initial unit tests are in place

**Remaining Tasks**:
- [ ] Create console application for testing entities
- [ ] Implement console CRUD operations
- [ ] Demonstrate value vs reference type behavior
- [ ] Document class vs struct differences

### Week 2 — Generics, Delegates & Events
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Implement `InMemoryRepository<T>` class
- [ ] Add events (`TaskAssigned`)
- [ ] Subscribe with lambda & method-group
- [ ] Write tests for repository and events

### Week 3 — LINQ, Lambdas & Anonymous Types
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Replace loops with LINQ filters
- [ ] Add search functionality using LINQ
- [ ] Create DTOs for projections
- [ ] Compare query vs method syntax

### Week 4 — Async/Await Basics
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Implement async methods in repositories
- [ ] Create `FileTaskRepository` with JSON I/O
- [ ] Add cancellation token support
- [ ] Run concurrent tasks

### Week 5 — EF Core Integration
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Add `DevTrackrDbContext`
- [ ] Create migrations
- [ ] Seed demo data
- [ ] Replace in-memory repo with EF Core

### Week 6 — C# 6 Modern Syntax
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Refactor with expression-bodied members
- [ ] Use interpolated strings
- [ ] Implement `nameof` operator
- [ ] Add null-conditional operators

### Week 7 — Tuples, Deconstruction, Pattern Matching
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Add `TaskStatisticsService` with tuple returns
- [ ] Implement deconstruction
- [ ] Use pattern matching in rules
- [ ] Implement `MinMax()` example

### Week 8 — Ref, Span<T>, Performance
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Optimize string operations with `Span<char>`
- [ ] Add BenchmarkDotNet
- [ ] Measure performance improvements
- [ ] Document optimization techniques

### Week 9 — Advanced Async Internals
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Add `OverdueCheckerService` (BackgroundService)
- [ ] Implement cancellation & try/finally
- [ ] Test cancellation mid-await
- [ ] Handle graceful shutdown

### Week 10 — Resilience & Channels
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Add `System.Threading.Channels` for notifications
- [ ] Implement Polly retry/circuit-breaker
- [ ] Test failure injection
- [ ] Observe breaker logs

### Week 11 — Testing & Nullable References
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Expand unit/integration tests
- [ ] Enable nullable refs incrementally
- [ ] Introduce and fix null bugs
- [ ] Address NRT warnings

### Week 12 — Capstone Wrap-up
**Status**: ⬜ Not Started

**Planned Implementation**:
- [ ] Finalize documentation
- [ ] Create demo showcasing features
- [ ] Tag v1.0 release
- [ ] Summarize learnings

## Key Areas for Development

1. **Repository Pattern**: Need to fully implement `InMemoryRepository<T>` and later replace with EF Core
2. **Testing**: Expand test coverage beyond current `TaskServiceTests`
3. **API Layer**: Current minimal API implementation needs to be connected to proper services
4. **Event System**: Add event publishing and subscription mechanisms
5. **Async Operations**: Implement full async/await patterns throughout
6. **Data Persistence**: Move from in-memory storage to EF Core with SQLite

## Next Steps

1. Complete Week 1 tasks (console CRUD, value/reference type demos)
2. Implement `InMemoryRepository<T>` for Week 2
3. Connect API layer to services and repositories
4. Expand test coverage