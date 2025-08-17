# DevTrackr 12-Week Study & Build Plan - Detailed Checklist

This checklist breaks down each week's tasks from the README.md into daily actionable items aligned with the DevTrackr project. Each week corresponds to specific C#/.NET concepts from *C# in Depth (4th ed.)*.

## Week 1 — Fundamentals & Type System

**Goal**: Establish core entities and basic console CRUD operations

### Day 1
- [ ] Read Chapter 1 of *C# in Depth (4th ed.)* (Type system & philosophy)
- [ ] Review existing entities: `TaskItem`, `User`, `Project`
- [ ] Understand value vs reference types in the current code

### Day 2
- [ ] Create a simple console application for testing entities
- [ ] Implement basic CRUD operations using `List<TaskItem>`
- [ ] Add console UI for creating, reading, updating, and deleting tasks

### Day 3
- [ ] Create demonstration of value vs reference type behavior
- [ ] Write code examples showing class vs struct differences
- [ ] Document findings in README.md or CAPSTONE.md

### Day 4
- [ ] Test all console CRUD operations
- [ ] Verify entity relationships work correctly
- [ ] Prepare checkpoint summary

### Day 5
- [ ] Complete checkpoint: Console CRUD works; explain class vs struct
- [ ] Update documentation with what was learned
- [ ] Plan for Week 2

## Week 2 — Generics, Delegates & Events

**Goal**: Implement generic repository pattern and add events to the system

### Day 1
- [ ] Read Chapter 2 of *C# in Depth (4th ed.)* (Generics, delegates, events)
- [ ] Review existing `IRepository<T>` interface
- [ ] Plan implementation of `InMemoryRepository<T>`

### Day 2
- [ ] Implement `InMemoryRepository<T>` class
- [ ] Ensure it implements all methods from `IRepository<T>`
- [ ] Test with `TaskItem`, `User`, and `Project` entities

### Day 3
- [ ] Add events to the system (`TaskAssigned`)
- [ ] Implement event publishing in relevant services
- [ ] Create event arguments class for task assignment

### Day 4
- [ ] Subscribe to events using lambda expressions
- [ ] Subscribe to events using method groups
- [ ] Test event functionality with different subscription approaches

### Day 5
- [ ] Complete checkpoint: Repository + events tested
- [ ] Write unit tests for `InMemoryRepository<T>`
- [ ] Document event usage patterns

## Week 3 — LINQ, Lambdas & Anonymous Types

**Goal**: Replace loops with LINQ and add DTO projections

### Day 1
- [ ] Read Chapter 3 of *C# in Depth (4th ed.)* (LINQ, lambda expressions)
- [ ] Review existing filtering in `TaskService`
- [ ] Identify areas where loops can be replaced with LINQ

### Day 2
- [ ] Replace loops with LINQ filters for task status
- [ ] Implement LINQ filtering by due dates
- [ ] Add search functionality using LINQ

### Day 3
- [ ] Create DTOs for data projections
- [ ] Implement projection from entities to DTOs using LINQ
- [ ] Compare query syntax vs method syntax in examples

### Day 4
- [ ] Demonstrate deferred vs immediate execution
- [ ] Create examples showing both execution patterns
- [ ] Document performance implications

### Day 5
- [ ] Complete checkpoint: Explain deferred vs immediate execution
- [ ] Test all LINQ implementations
- [ ] Update documentation with LINQ patterns used

## Week 4 — Async/Await Basics

**Goal**: Add async repository methods and implement file-based repository

### Day 1
- [ ] Read Chapter 5 of *C# in Depth (4th ed.)* (async usage, cancellation)
- [ ] Review existing async methods in `IRepository<T>`
- [ ] Plan implementation of async methods in `InMemoryRepository<T>`

### Day 2
- [ ] Implement async methods in `InMemoryRepository<T>`
- [ ] Add proper async/await patterns
- [ ] Test async repository operations

### Day 3
- [ ] Implement `FileTaskRepository` (JSON I/O)
- [ ] Add serialization/deserialization of tasks to JSON
- [ ] Implement file read/write operations with async/await

### Day 4
- [ ] Add cancellation token support to file operations
- [ ] Implement cancellation in long-running operations
- [ ] Test cancellation functionality

### Day 5
- [ ] Run two tasks concurrently and combine results
- [ ] Complete checkpoint: Async CRUD + cancellation works
- [ ] Document async patterns and cancellation usage

## Week 5 — EF Core Integration

**Goal**: Replace in-memory repository with EF Core persistence

### Day 1
- [ ] Read LINQ notes + EF Core documentation
- [ ] Plan `DevTrackrDbContext` implementation
- [ ] Identify entities that need to be persisted

### Day 2
- [ ] Add EF Core NuGet packages to project
- [ ] Implement `DevTrackrDbContext`
- [ ] Configure entity mappings

### Day 3
- [ ] Create initial migration
- [ ] Implement database seeding with demo data
- [ ] Test database creation and seeding

### Day 4
- [ ] Replace `InMemoryRepository<T>` with EF Core implementation
- [ ] Update dependency injection to use EF Core repositories
- [ ] Test all CRUD operations with database

### Day 5
- [ ] Fix N+1 query issues by using projections
- [ ] Complete checkpoint: API persists to SQLite
- [ ] Document EF Core integration and performance considerations

## Week 6 — C# 6 Modern Syntax

**Goal**: Refactor codebase using modern C# 6+ syntax features

### Day 1
- [ ] Read Chapters 8-10 of *C# in Depth (4th ed.)*
- [ ] Identify areas for refactoring with expression-bodied members
- [ ] Plan syntax improvements

### Day 2
- [ ] Refactor properties and methods with expression-bodied syntax
- [ ] Replace string concatenation with interpolated strings
- [ ] Use `nameof` operator for property names

### Day 3
- [ ] Implement null-conditional operators where appropriate
- [ ] Add null-forgiving operators where needed
- [ ] Test refactored code for functionality

### Day 4
- [ ] Implement caller information attributes for logging
- [ ] Add parameter information to logging messages
- [ ] Test caller info functionality

### Day 5
- [ ] Complete checkpoint: Cleaner idiomatic C# code
- [ ] Review all refactored code
- [ ] Document modern syntax patterns used

## Week 7 — Tuples, Deconstruction, Pattern Matching

**Goal**: Add statistics service and implement pattern matching

### Day 1
- [ ] Read Chapters 11-12 of *C# in Depth (4th ed.)*
- [ ] Plan `TaskStatisticsService` implementation
- [ ] Identify statistics to calculate

### Day 2
- [ ] Implement `TaskStatisticsService` with tuple returns
- [ ] Create methods that return multiple values using tuples
- [ ] Test statistics calculations

### Day 3
- [ ] Implement deconstruction in services
- [ ] Add deconstruction examples to entities
- [ ] Test deconstruction functionality

### Day 4
- [ ] Use pattern matching in business rules
- [ ] Implement switch expressions with pattern matching
- [ ] Add property patterns and tuple patterns

### Day 5
- [ ] Implement `MinMax()` example from book
- [ ] Complete checkpoint: Tuple + pattern usage works
- [ ] Document pattern matching use cases

## Week 8 — Ref, Span<T>, Performance

**Goal**: Optimize string operations with Span<T> and benchmark performance

### Day 1
- [ ] Read Chapter 13 of *C# in Depth (4th ed.)* + Span documentation
- [ ] Identify string operations that could be optimized
- [ ] Plan Span<T> implementation

### Day 2
- [ ] Add BenchmarkDotNet NuGet package
- [ ] Create benchmark tests for existing string operations
- [ ] Establish performance baseline

### Day 3
- [ ] Optimize string operations with `Span<char>`
- [ ] Implement Span-based versions of string operations
- [ ] Ensure correctness of optimized versions

### Day 4
- [ ] Recreate book's Span allocation example
- [ ] Measure memory allocation differences
- [ ] Document performance improvements

### Day 5
- [ ] Complete checkpoint: Benchmark proves allocation reduction
- [ ] Compare performance of original vs optimized code
- [ ] Document performance optimization techniques

## Week 9 — Advanced Async Internals

**Goal**: Implement background service with advanced async patterns

### Day 1
- [ ] Read Chapter 6 of *C# in Depth (4th ed.)* (state machine, try/finally, context)
- [ ] Plan `OverdueCheckerService` implementation
- [ ] Identify requirements for overdue task checking

### Day 2
- [ ] Implement `OverdueCheckerService` as BackgroundService
- [ ] Add logic to check for overdue tasks
- [ ] Implement cancellation token handling

### Day 3
- [ ] Add try/finally blocks for resource cleanup
- [ ] Implement proper exception handling
- [ ] Test service behavior under normal conditions

### Day 4
- [ ] Test cancellation mid-await scenarios
- [ ] Verify service behaves safely under shutdown
- [ ] Handle graceful shutdown scenarios

### Day 5
- [ ] Complete checkpoint: Service behaves safely under shutdown
- [ ] Document async state machine behavior
- [ ] Update service documentation

## Week 10 — Resilience & Channels

**Goal**: Add resilient notification system with channels and Polly

### Day 1
- [ ] Read async best practices + Polly documentation
- [ ] Plan notification system with `System.Threading.Channels`
- [ ] Identify external service calls that need resilience

### Day 2
- [ ] Add `System.Threading.Channels` for notification queue
- [ ] Implement producer/consumer pattern for notifications
- [ ] Test channel functionality

### Day 3
- [ ] Add Polly NuGet package
- [ ] Wrap external service calls with Polly retry policies
- [ ] Configure retry strategies

### Day 4
- [ ] Implement circuit breaker patterns with Polly
- [ ] Add logging for circuit breaker state changes
- [ ] Test circuit breaker functionality

### Day 5
- [ ] Inject failures and observe breaker logs
- [ ] Complete checkpoint: Notifications resilient to transient failures
- [ ] Document resilience patterns implemented

## Week 11 — Testing & Nullable References

**Goal**: Expand test coverage and enable nullable reference types

### Day 1
- [ ] Read Chapter 15 of *C# in Depth (4th ed.)* (nullable refs + migration)
- [ ] Plan test expansion strategy
- [ ] Enable nullable reference types in project

### Day 2
- [ ] Expand unit tests for existing services
- [ ] Add integration tests for API endpoints
- [ ] Test edge cases and error conditions

### Day 3
- [ ] Incrementally enable nullable references
- [ ] Address compiler warnings
- [ ] Add null-forgiving operators where necessary

### Day 4
- [ ] Introduce intentional null bug for testing
- [ ] Verify compiler warning appears
- [ ] Fix bug and verify warning is resolved

### Day 5
- [ ] Complete checkpoint: Tests + NRT warnings addressed
- [ ] Document testing approach and nullable reference migration
- [ ] Plan for final week

## Week 12 — Capstone Wrap-up

**Goal**: Finalize project with documentation and demo

### Day 1
- [ ] Read Chapters 1 + 15 of *C# in Depth (4th ed.)* (design philosophy)
- [ ] Plan final documentation updates
- [ ] Prepare demo showcasing language concepts

### Day 2
- [ ] Finalize README.md with complete project documentation
- [ ] Create CAPSTONE.md with lessons learned
- [ ] Document features tied to each language concept

### Day 3
- [ ] Create short demo showing features tied to language concepts
- [ ] Record or prepare demo materials
- [ ] Test demo scenarios

### Day 4
- [ ] Tag v1.0 release
- [ ] Create release notes
- [ ] Summarize learnings from each week

### Day 5
- [ ] Complete checkpoint: Tag v1.0 and summarize learnings
- [ ] Final review of all project components
- [ ] Celebrate completion!