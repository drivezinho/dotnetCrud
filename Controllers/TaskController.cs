using System;
using System.Collections.Generic;
using dotnet.Servoces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private TasksService service;

        public TasksController(TasksService service){
            this.service = service;
        }

        [HttpGet]
        public List<Task> Get(){
            return service.GetTasks();
        }

        [HttpGet("{taskId}")]
        public Task GetById(int taskId){
           return service.GetById(taskId);
        }

        [HttpPost]
        public void Post(Task task){
            service.InsertTask(task);
        }

        [HttpPut]
        public void Put(Task task){
            service.UpdateTask(task);
        }

        [HttpDelete]
        public void Delete(int taskId){
            service.DeleteTask(taskId);
        }
    }
}
