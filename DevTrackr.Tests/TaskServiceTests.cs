using DevTrackr.Core.Entities;
using DevTrackr.Core.Interfaces;
using DevTrackr.Core.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DevTrackr.Tests
{
    public class TaskServiceTests
    {
        [Fact]
        public async Task GetPendingTasksAsync_Should_Return_Only_Pending_Tasks()
        {
            // Arrange
            var mockRepo = new Mock<IRepository<TaskItem>>();
            var tasks = new List<TaskItem>
            {
                new TaskItem { Id = 1, Title = "Task 1", Status = DevTrackr.Core.Entities.TaskStatus.Pending },
                new TaskItem { Id = 2, Title = "Task 2", Status = DevTrackr.Core.Entities.TaskStatus.InProgress },
                new TaskItem { Id = 3, Title = "Task 3", Status = DevTrackr.Core.Entities.TaskStatus.Pending }
            };
            mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(tasks);

            var service = new TaskService(mockRepo.Object);

            // Act
            var result = await service.GetPendingTasksAsync();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.All(result, t => Assert.Equal(DevTrackr.Core.Entities.TaskStatus.Pending, t.Status));
        }

        [Fact]
        public async Task UpdateTaskStatusAsync_Should_Return_False_If_Task_Not_Found()
        {
            // Arrange
            var mockRepo = new Mock<IRepository<TaskItem>>();
            mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((TaskItem?)null);

            var service = new TaskService(mockRepo.Object);

            // Act
            var result = await service.UpdateTaskStatusAsync(999, DevTrackr.Core.Entities.TaskStatus.Completed);

            // Assert
            Assert.False(result);
        }
    }
}