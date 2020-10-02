using System.Collections.Generic;
using System.Linq;

namespace dotnet.Servoces{

    public class TasksService {

        private List<Task> Tasks;

        public TasksService(){
            Tasks = new List<Task>();
        }

        public List<Task> GetTasks(){
            return Tasks;
        }
        public void InsertTask(Task task){
            var lastTask = Tasks.LastOrDefault();
            task.Id = lastTask != null ? lastTask.Id + 1 : 1;
            Tasks.Add(task);
        }
        public void UpdateTask(Task task){
           var index = Tasks.FindIndex(x => x.Id == task.Id);
           Tasks[index] = task;
        }
        public void DeleteTask(int taskId){
            Tasks.Remove(Tasks.Find (x => x.Id == taskId));
        }

        public Task GetById(int taskId){
            return Tasks.FirstOrDefault (x => x.Id == taskId);
        }
    }
}