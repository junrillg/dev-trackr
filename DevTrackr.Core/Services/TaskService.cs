using DevTrackr.Core.Entities;
using DevTrackr.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTrackr.Core.Services
{
    public class TaskService
    {
        private readonly IRepository<TaskItem> _taskRepository;

        public TaskService(IRepository<TaskItem> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<TaskItem>> GetPendingTasksAsync()
        {
            var tasks = await _taskRepository.GetAllAsync();
            return tasks.Where(t => t.Status == Entities.TaskStatus.Pending);
        }

        public async Task<bool> UpdateTaskStatusAsync(int taskId, Entities.TaskStatus newStatus)
        {
            var task = await _taskRepository.GetByIdAsync(taskId);
            if (task == null)
                return false;

            task.Status = newStatus;
            await _taskRepository.UpdateAsync(task);
            return true;
        }
    }
}